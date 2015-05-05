namespace Frameplate.CQRS
{
    public interface IQueryDescriptor<out TResult>
    {
        TResult Execute<TCriterion>(TCriterion criterion)
            where TCriterion : class, ICriterion;
    }
}