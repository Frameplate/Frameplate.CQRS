namespace Frameplate.CQRS
{
    public class CommandBuilder : ICommandBuilder
    {
        private readonly ICommandFactory _commandFactory;

        public CommandBuilder(ICommandFactory commandFactory)
        {
            _commandFactory = commandFactory;
        }

        public void Execute<TCommandContext>(TCommandContext context)
            where TCommandContext : class, ICommandContext
        {
            _commandFactory.Create<TCommandContext>().Execute(context);
        }
    }
}