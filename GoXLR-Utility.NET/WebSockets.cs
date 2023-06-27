using System;
using System.IO;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoXLR_Utility.NET.Light
{
    public class WebSockets : IDisposable
    {
        private ClientWebSocket _ws;
        private CancellationTokenSource _cTokenSource;
        private Uri _url;
        private bool _isConnected;
        private Task _receiveMessageTask;
        private Task _connectionTask;

        public event EventHandler<string> OnConnected;
        public event EventHandler<string> OnDisconnected;
        public event EventHandler<string> OnMessage;
        public event EventHandler<ErrorEventArgs> OnError;
        
        public void Initialize(string url)
        {
            _ws = new ClientWebSocket();
            _cTokenSource = new CancellationTokenSource();
            _url = new Uri(url);
        }

        public async Task<bool> ConnectAsync()
        {
            _receiveMessageTask = ReceiveMessageService();
            _connectionTask = ConnectionService();
            await _ws.ConnectAsync(_url, _cTokenSource.Token);
            await Task.Delay(50);
            return _ws.State == WebSocketState.Open;
        }

        public async Task DisconnectAsync()
        {
            //await _ws.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);
            Dispose();
            OnDisconnected?.Invoke(this, null);
        }

        public async Task<bool> SendAsync(long id, string message)
        {
            await _ws.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(message)), WebSocketMessageType.Text, true, _cTokenSource.Token);
            return await ReceiveResult(id);
        }

        public async Task<bool> ReceiveResult(long id)
        {
            using (var timeoutSource = new CancellationTokenSource(TimeSpan.FromSeconds(1)))
            {
                var responseSource = new TaskCompletionSource<bool>();
                
                EventHandler<string> eventHandler = (sender, message) =>
                {
                    if (message.Contains($"\"id\":{id}"))
                        responseSource.SetResult(true);
                };

                OnMessage += eventHandler;

                try
                {
                    var responseTask = responseSource.Task;
                    var completedTask = await Task.WhenAny(responseTask, Task.Delay(-1, timeoutSource.Token));

                    if (completedTask == responseTask)
                        return await responseTask;

                    
                    return false;
                }
                catch
                {
                    return false;
                }
                finally
                {
                    OnMessage -= eventHandler;
                }
            }
        }

        public async Task ConnectionService()
        {
            while (!_cTokenSource.IsCancellationRequested)
            {
                switch (_ws.State)
                {
                    case WebSocketState.Open:
                        if (!_isConnected)
                            OnConnected?.Invoke(this, null);

                        _isConnected = true;
                        break;
                    case WebSocketState.Aborted:
                    case WebSocketState.Closed:
                        if (_isConnected)
                            OnDisconnected?.Invoke(this, null);

                        _isConnected = false;
                        break;
                }

                await Task.Delay(200);
            }
        }

        private async Task ReceiveMessageService()
        {
            var memoryStream = new MemoryStream();
            var bytes = new byte[1024];
            var buffer = new ArraySegment<byte>(bytes);

            WebSocketReceiveResult result = null;
            while (!_cTokenSource.IsCancellationRequested)
            {
                if (_ws.State != WebSocketState.Open)
                {
                    await Task.Delay(20);
                    continue;
                }
                
                try
                {
                    result = await _ws.ReceiveAsync(buffer, _cTokenSource.Token);
                }
                catch (TaskCanceledException) { }
                catch (OperationCanceledException e)
                {
                    Console.WriteLine(e);
                }
                catch (Exception e)
                {
                    OnError?.Invoke(this, new ErrorEventArgs($"Fatal error in {nameof(ReceiveMessageService)}", e));
                }

                if (result is null)
                    continue;

                switch (result.MessageType)
                {
                    case WebSocketMessageType.Text:
                        if (result.EndOfMessage && memoryStream.Position == 0)
                        {
                            var message = Encoding.UTF8.GetString(bytes, 0, result.Count);
                            OnMessage?.Invoke(this, message);
                            break;
                        }
                        memoryStream.Write(bytes, 0, result.Count);
                        if (result.EndOfMessage)
                        {
                            var message = Encoding.UTF8.GetString(memoryStream.GetBuffer(), 0,
                                (int)memoryStream.Position);
                            OnMessage?.Invoke(this, message);
                            memoryStream.Position = 0;
                        }
                        break;
                    case WebSocketMessageType.Close:
                        await DisconnectAsync();
                        break;
                    case WebSocketMessageType.Binary:
                        OnError?.Invoke(this, new ErrorEventArgs("Received Binary from WebSocket, couldn't be processed", new ArgumentOutOfRangeException()));
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        public void Dispose()
        {
            _cTokenSource.Cancel();
            var success = Task.WaitAll(new[]{_receiveMessageTask, _connectionTask}, TimeSpan.FromSeconds(5));
            if (!success)
            {
                OnError?.Invoke(this, new ErrorEventArgs("Critical Error disposing Tasks", null));
                Console.WriteLine("Critical Error disposing Tasks");
                return;
            }
            
            _cTokenSource?.Dispose();
            _ws?.Dispose();
            _receiveMessageTask?.Dispose();
            _connectionTask?.Dispose();
        }
    }

    public class ErrorEventArgs : EventArgs
    {
        public string Message { get; set; }
        public Exception Exception { get; set; }

        public ErrorEventArgs(string message, Exception exception)
        {
            Message = message;
            Exception = exception;
        }
    }
}