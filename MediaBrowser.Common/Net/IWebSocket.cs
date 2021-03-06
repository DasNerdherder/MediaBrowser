﻿using System;
using System.Threading;
using System.Threading.Tasks;
using MediaBrowser.Model.Net;

namespace MediaBrowser.Common.Net
{
    /// <summary>
    /// Interface IWebSocket
    /// </summary>
    public interface IWebSocket : IDisposable
    {
        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        WebSocketState State { get; }

        /// <summary>
        /// Gets or sets the receive action.
        /// </summary>
        /// <value>The receive action.</value>
        Action<byte[]> OnReceiveDelegate { get; set; }

        /// <summary>
        /// Sends the async.
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        /// <param name="type">The type.</param>
        /// <param name="endOfMessage">if set to <c>true</c> [end of message].</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task.</returns>
        Task SendAsync(byte[] bytes, WebSocketMessageType type, bool endOfMessage, CancellationToken cancellationToken);
    }
}
