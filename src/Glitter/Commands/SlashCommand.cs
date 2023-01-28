using Microsoft.Extensions.Logging;

namespace Glitter.Commands;

/// <summary>
/// Represents a slash command that can be executed by a chatbot.
/// </summary>
public abstract class SlashCommand : Command
{
    /// <summary>
    /// Creates a new <see cref="SlashCommand"/> instance.
    /// </summary>
    /// <param name="key">The key for invoking the <see cref="SlashCommand"/>.</param>
    /// <param name="description">The description for the <see cref="SlashCommand"/>.</param>
    /// <param name="logger">The logger the <see cref="SlashCommand"/> should utilize.</param>
    protected SlashCommand(string key, string description, ILogger logger) :
        base(key, description, logger)
    { }
    /// <summary>
    /// Creates a new <see cref="SlashCommand"/> instance.
    /// </summary>
    /// <param name="key">The key for invoking the <see cref="SlashCommand"/>.</param>
    /// <param name="displayName">The display name for the <see cref="SlashCommand"/>.</param>
    /// <param name="description">The description for the <see cref="SlashCommand"/>.</param>
    /// <param name="logger">The logger the <see cref="SlashCommand"/> should utilize.</param>
    protected SlashCommand(string key, string displayName, string description, ILogger logger) :
        base(key, displayName, description, logger)
    { }
}
