using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Glitter.Commands.OpenSource.Baseline;

public class HelpCommand : SlashCommand
{
    public HelpCommand(string key, string description, ILogger logger) : base(key, description, logger)
    {
    }
    protected override Task<CommandResponse> Work(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}