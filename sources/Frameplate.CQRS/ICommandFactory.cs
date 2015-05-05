namespace Frameplate.CQRS
{
    public interface ICommandFactory
    {
        ICommand<TCommandContext> Create<TCommandContext>() 
            where TCommandContext : class, ICommandContext;
    }
}