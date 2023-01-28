using Glitter.Ai;

using Mauve.Extensibility;
using Mauve.Math;

using Microsoft.Extensions.Logging;

namespace Glitter.Commands;

/// <summary>
/// Represents a command capable of being executed by a <see cref="Chatbot"/>/
/// </summary>
public abstract class Command
{
    /// <summary>
    /// The logger for the <see cref="Command"/>.
    /// </summary>
    protected ILogger Logger { get; private set; }
    /// <summary>
    /// The key used to identify the <see cref="Command"/>.
    /// </summary>
    public string Key { get; set; }
    /// <summary>
    /// The display name for the <see cref="Command"/>.
    /// </summary>
    public string DisplayName { get; set; }
    /// <summary>
    /// A description of what the <see cref="Command"/> does.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Creates a new <see cref="Command"/> instance.
    /// </summary>
    /// <param name="key">The key used to identify the <see cref="Command"/>.</param>
    /// <param name="description">A description of what the <see cref="Command"/> does.</param>
    /// <param name="logger"></param>
    protected Command(string key, string description, ILogger logger) :
        this(key, key, description, logger)
    { }
    /// <summary>
    /// Creates a new <see cref="Command"/> instance.
    /// </summary>
    /// <param name="key">The key used to identify the <see cref="Command"/>.</param>
    /// <param name="displayName">The display name for the <see cref="Command"/>.</param>
    /// <param name="description">A description of what the <see cref="Command"/> does.</param>
    /// <param name="logger"></param>
    protected Command(string key, string displayName, string description, ILogger logger)
    {
        Key = key;
        Logger = logger;
        DisplayName = displayName;
        Description = description;
    }
    /// <summary>
    /// Executes the <see cref="Command"/>.
    /// </summary>
    /// <param name="cancellationToken">A <see cref="CancellationToken"/> to be utilized during execution to signal cancellation.</param>
    /// <returns>A <see cref="Task"/> describing the state of the operation.</returns>
    public async Task<CommandResponse?> Execute(CancellationToken cancellationToken)
    {
        bool encounteredErrors = false;
        CommandResponse? response = null;
        Logger.LogDebug($"Executing command '{DisplayName}'...");
        try
        {
            response = await Work(cancellationToken);
        } catch (Exception e)
        {
            Logger.LogError($"An unexpected error occurred during execution. {e.Message}");
        } finally
        {
            // Set the event type for the completion message.
            LogLevel logLevel = encounteredErrors
                ? LogLevel.Error
                : LogLevel.Information;

            // Log the completion message.
            Logger.Log(logLevel, "Execution complete.");
        }

        return response;
    }
    protected abstract Task<CommandResponse> Work(CancellationToken cancellationToken);
}