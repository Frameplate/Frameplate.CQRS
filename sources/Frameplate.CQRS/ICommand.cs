namespace Frameplate.CQRS
{
    public interface ICommand<in TCommandContext>
        where TCommandContext : class, ICommandContext
    {
        void Execute(TCommandContext context);
    }
}