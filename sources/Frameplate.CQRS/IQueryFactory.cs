namespace Frameplate.CQRS
{
    public interface IQueryFactory
    {
        IQuery<TCriterion, TResult> Create<TCriterion, TResult>()
            where TCriterion : class, ICriterion;
    }
}