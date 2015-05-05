namespace Frameplate.CQRS
{
    public abstract class QueryBase<TCriterion, TResult> : IQuery<TCriterion, TResult>
        where TCriterion : class, ICriterion
    {
        public IQueryBuilder SubQuery { get; set; }

        public abstract TResult Execute(TCriterion criterion);
    }
}