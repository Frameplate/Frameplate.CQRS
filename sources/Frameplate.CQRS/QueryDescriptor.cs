namespace Frameplate.CQRS
{
    public class QueryDescriptor<TResult> : IQueryDescriptor<TResult>
    {
        private readonly IQueryFactory _queryFactory;

        public QueryDescriptor(IQueryFactory queryFactory)
        {
            _queryFactory = queryFactory;
        }

        public TResult Execute<TCriterion>(TCriterion criterion)
            where TCriterion : class, ICriterion
        {
            return _queryFactory.Create<TCriterion, TResult>().Execute(criterion);
        }
    }
}