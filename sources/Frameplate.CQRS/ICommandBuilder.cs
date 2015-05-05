namespace Frameplate.CQRS
{
    public interface ICommandBuilder
    {
        void Execute<TCommandContext>(TCommandContext context)
            where TCommandContext : class, ICommandContext;
    }
}