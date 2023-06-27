using System.Collections.Generic;
using System.Linq;
using GoXLR_Utility.NET.Core;
using GoXLR_Utility.NET.Models.Response.HttpSettings;
using GoXLR_Utility.NET.Models.Response.Status;
using GoXLR_Utility.NET.Models.Response.Status.Config;
using GoXLR_Utility.NET.Models.Response.Status.Files;
using GoXLR_Utility.NET.Models.Response.Status.Mixer;
using GoXLR_Utility.NET.Models.Response.Status.Paths;
using Microsoft.Extensions.Logging;

namespace GoXLR_Utility.NET
{
    public class Utility : UtilityBase
    {
        private readonly MessageHandler _messageHandler;

        /// <summary>
        /// The Daemon Status including:
        /// <br/><see cref="Config"/>,
        /// <br/><see cref="Files"/>,
        /// <br/><see cref="Device"/> as Dictionary using SerialNumber,
        /// <br/><see cref="Paths"/>
        /// </summary>
        public Status Status => _messageHandler.Status;

        /// <summary>
        /// The Daemon HttpSettings
        /// </summary>
        public HttpSettings HttpSettings => _messageHandler.HttpSettings;
        
        /// <summary>
        /// A List of available SerialNumbers
        /// </summary>
        public List<string> AvailableSerialNumbers => Status.Mixers.Keys.ToList();

        /// <inheritdoc />
        public Utility(ILogger logger = null) : base(logger)
        {
            _messageHandler = new MessageHandler();
        }
        
        /// <inheritdoc />
        protected override void OnWsMessage(object sender, string message)
        {
            Logger?.Log(LogLevel.Debug, new EventId(1, "Daemon connectivity"), "Message from Utility received: {message}", message);
            _messageHandler.HandleMessage(message);
        }
    }
}