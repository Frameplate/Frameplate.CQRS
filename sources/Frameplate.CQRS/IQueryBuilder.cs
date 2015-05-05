namespace Frameplate.CQRS
{
    public interface IQueryBuilder
    {                                                
        IQueryDescriptor<TResult> ResultingIn<TResult>();
    }
}