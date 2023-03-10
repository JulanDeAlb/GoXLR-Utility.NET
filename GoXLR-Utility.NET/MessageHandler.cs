using System;
using System.Text.Json;
using GoXLR_Utility.NET.Models.Response;
using GoXLR_Utility.NET.Models.Response.HttpSettings;
using GoXLR_Utility.NET.Models.Response.Status;
using Microsoft.Extensions.Logging;

namespace GoXLR_Utility.NET
{
    public class MessageHandler
    {
        private static PatchHandler _patchHandler;
        private static ILogger _logger;
        
        public Status Status;
        public HttpSettings HttpSettings;

        /// <summary>
        /// Initialize the MessageHandler with Serializer Options.
        /// </summary>
        /// <param name="logger">Optional Logger primary for Tests.</param>
        public MessageHandler(ILogger logger = null)
        {
            _logger = logger ?? Utility.Logger;
            _patchHandler = new PatchHandler(logger);
        }

        /// <summary>
        /// Handle new Messages coming from the Daemon
        /// </summary>
        /// <param name="message">Message to handle.</param>
        public void HandleMessage(string message)
        {
            Response response;
            try
            {
                response  = JsonSerializer.Deserialize<Response>(message, Utility.SerializerOptions);
            }
            catch (Exception e)
            {
                _logger?.Log(LogLevel.Error, new EventId(3, "Message Handler"), e, "Unable to deserialize Message.");
                return;
            }

            if (response is null)
            {
                _logger?.Log(LogLevel.Error, new EventId(3, "Message Handler"), "Deserialized JSON is null.");
                return;
            }

            if (response.SimpleData != null)
            {
                //Simple Data is just OK, maybe an Event after X seconds when id doesnt come back.
            }
            else if (response.Data?.Error != null)
            {
                _logger?.Log(LogLevel.Error, new EventId(4, "Daemon Error"), "Received Error from Daemon: {error}", response.Data.Error);
            } else if (response.Data?.HttpState != null)
            {
                HttpSettings = response.Data.HttpState;
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