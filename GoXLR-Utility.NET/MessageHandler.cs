using System;
using System.Text.Json;
using GoXLR_Utility.NET.Models.Response;
using GoXLR_Utility.NET.Models.Response.Status;

namespace GoXLR_Utility.NET
{
    public class MessageHandler
    {
        private static PatchHandler _patchHandler;
        private static JsonSerializerOptions _serializerOptions;
        
        public Status Status;

        public MessageHandler(JsonSerializerOptions serializerOptions)
        {
            _patchHandler = new PatchHandler(serializerOptions);
            _serializerOptions = serializerOptions;
        }
        
        public void HandleMessage(string message)
        {
            Response response;
            try
            {
                response  = JsonSerializer.Deserialize<Response>(message, _serializerOptions);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); //TODO Log exception
                return;
            }
            
            if (response is null)
                throw new ArgumentNullException(nameof(HandleMessage)); // TODO Log it

            if (response.SimpleData != null)
            {
                
            }
            else if (response.Data.Error != null)
            {
                Console.WriteLine($"Error WS Message | {response.Data.Error}"); //TODO Log the WS Message for implementation
            } else if (response.Data.HttpState != null)
            {
                
            } else if (response.Data.Status != null)
            {
                Status = response.Data.Status;
            } else if (response.Data.Patch != null)
            {
                _patchHandler.HandlePatch(Status, response.Data.Patch);
            }
        }
    }
}