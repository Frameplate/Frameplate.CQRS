namespace Frameplate.CQRS.Extensions
{
    using Criteria;

    public static class QueryDescriptorExtensions
    {
        public static TResult Execute<TResult>(this IQueryDescriptor<TResult> queryDescriptor)
        {
            return queryDescriptor.Execute(Criterion.Empty);
        }

        public static TResult ById<TResult, TIdType>(this IQueryDescriptor<TResult> queryDescriptor, TIdType id)
        {
            return queryDescriptor.Execute(Criterion.Id(id));
        }

        public static TResult ByIdList<TResult, TIdType>(this IQueryDescriptor<TResult> queryDescriptor, params TIdType[] id)
        {
            return queryDescriptor.Execute(Criterion.IdList(id));
        }
    }
}