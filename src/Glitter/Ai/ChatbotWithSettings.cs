using MediatR;

using Microsoft.Extensions.Logging;

namespace Glitter.Ai;

/// <summary>
/// Represents a <see cref="Chatbot"/> with settings.
/// </summary>
/// <typeparam name="TSettings">Specifies the type used for settings.</typeparam>
public abstract class Chatbot<TSettings> : Chatbot
{
    /// <summary>
    /// The settings for the <see cref="Chatbot"/>.
    /// </summary>
    protected TSettings Settings { get; set; }
    /// <summary>
    /// Creates a new <see cref="Chatbot"/> instance.
    /// </summary>
    /// <param name="name">The name of the <see cref="Chatbot"/>.</param>
    /// <param name="settings">The settings for the <see cref="Chatbot"/>.</param>
    /// <param name="mediator">The mediator for handling <see cref="Command"/> requests.</param>
    /// <param name="logger">The logger for the <see cref="Chatbot"/>.</param>
    protected Chatbot(
        string name,
        TSettings settings,
        IMediator mediator,
        ILogger logger) :
        base(name, mediator, logger) =>
        Settings = settings;
}
