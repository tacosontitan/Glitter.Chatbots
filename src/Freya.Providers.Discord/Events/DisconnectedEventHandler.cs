using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mauve.Extensibility;
using Microsoft.Extensions.Logging;
using Discord.WebSocket;

namespace Freya.Providers.Discord.Events
{
    /// <summary>
    /// Represents an <see cref="EventHandler"/> for handling the disconnected event for a <see cref="DiscordSocketClient"/>.
    /// </summary>
    internal sealed class DisconnectedEventHandler : EventHandler
    {
        /// <summary>
        /// Creates a new <see cref="ConnectedEventHandler"/> instance.
        /// </summary>
        /// <param name="client">The <see cref="DiscordSocketClient"/> to handle disconnected events for.</param>
        /// <param name="logger">The logger for the <see cref="DiscordChatbot"/>.</param>
        public DisconnectedEventHandler(DiscordSocketClient client, ILogger logger) :
            base(logger) =>
            client.Disconnected += HandleDisconnect;
        private async Task HandleDisconnect(Exception arg)
        {
            Logger.LogError($"Disconnected from Discord. {arg.FlattenMessages(" ")}");
            await Task.CompletedTask;
        }
    }
}