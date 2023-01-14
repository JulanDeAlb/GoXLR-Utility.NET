using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json;
using GoXLR_Utility.NET.Models.DaemonResponse;
using GoXLR_Utility.NET.Models.Response.Status;

namespace GoXLR_Utility.NET
{
    public class MessageHandler
    {
        private static PatchHandler _patchHandler;
        private static JsonSerializerOptions _serializerOptions;
        private static Status _status;
        
        public static List<string> AvailableSerialNumbers = new List<string>();

        public MessageHandler(Events.Events events, Status status, JsonSerializerOptions serializerOptions)
        {
            _patchHandler = new PatchHandler(events, serializerOptions);
            _status = status;
            _serializerOptions = serializerOptions;
        }

        private static Stopwatch w = new Stopwatch();
        
        public void HandleMessage(string message)
        {
            double  ticks;
            double  seconds;
            double  milliseconds;
            double  nanoseconds;
            
            w.Start();
            Response response;
            try
            {
                response  = JsonSerializer.Deserialize<Response>(message, _serializerOptions);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); //TODO Log exception
                w.Stop();
                ticks = w.ElapsedTicks;
                seconds = ticks / Stopwatch.Frequency;
                milliseconds = (ticks / Stopwatch.Frequency) * 1000;
                nanoseconds = (ticks / Stopwatch.Frequency) * 1000000000;
                Console.WriteLine($"s: {seconds} | ms: {milliseconds} | ns: {nanoseconds} | t: {ticks} | ");
                w.Reset();
                return;
            }
            
            w.Stop();
            ticks = w.ElapsedTicks;
            seconds = ticks / Stopwatch.Frequency;
            milliseconds = (ticks / Stopwatch.Frequency) * 1000;
            nanoseconds = (ticks / Stopwatch.Frequency) * 1000000000;
            Console.WriteLine($"s: {seconds} | ms: {milliseconds} | ns: {nanoseconds} | t: {ticks} | ");
            w.Reset();
            
            if (response is null)
                throw new ArgumentNullException(nameof(HandleMessage)); // TODO Log it

            if (response.SimpleData != null)
            {
                
            }
            else if (response.Data.Error != null)
            {
                throw new NotImplementedException("Error WS Message"); //TODO Log the WS Message for implementation
                /*
                 OnErrorResponseReceived?.Invoke(this, new OnErrorResponseReceivedEventArgs
                {
                    Id = response.Id,
                });
                */
            } else if (response.Data.HttpState != null)
            {
                
            } else if (response.Data.Status != null)
            {
                _status = response.Data.Status;
            } else if (response.Data.Patch != null)
            {
                _patchHandler.HandlePatch(_status, response.Data.Patch);
            }
        }
    }
}