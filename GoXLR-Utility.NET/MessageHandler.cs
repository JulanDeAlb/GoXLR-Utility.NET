using System;
using System.Text.Json;
using GoXLR_Utility.NET.Models.Response;
using GoXLR_Utility.NET.Models.Response.Status;
using Microsoft.Extensions.Logging;

namespace GoXLR_Utility.NET
{
    public class MessageHandler
    {
        private static PatchHandler? _patchHandler;
        private static JsonSerializerOptions? _serializerOptions;
        
        public Status Status = null!;

        public MessageHandler(JsonSerializerOptions? serializerOptions)
        {
            _patchHandler = new PatchHandler(serializerOptions);
            _serializerOptions = serializerOptions;
        }

        public void HandleMessage(string message)
        {
            Response? response;
            try
            {
                response  = JsonSerializer.Deserialize<Response>(message, _serializerOptions);
            }
            catch (Exception e)
            {
                Utility.Logger?.Log(LogLevel.Error, new EventId(3, "MessageHandler"), e, "Unable to deserialize Message.");
                return;
            }

            if (response is null)
            {
                Utility.Logger?.Log(LogLevel.Error, new EventId(3, "MessageHandler"), "Deserialized JSON is null.");
                return;
            }

            if (response.SimpleData != null)
            {
                //TODO Simple Data
            }
            else if (response.Data?.Error != null)
            {
                Utility.Logger?.Log(LogLevel.Error, new EventId(4, "Daemon Error"), "Received Error from Daemon: {error}", response.Data.Error);
            } else if (response.Data?.HttpState != null)
            {
                //TODO HttpState
            } else if (response.Data?.Status != null)
            {
                Status = response.Data.Status;
            } else if (response.Data?.Patch != null)
            {
                _patchHandler?.HandlePatch(Status, response.Data.Patch);
            }
        }
    }
}