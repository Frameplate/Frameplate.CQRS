namespace Frameplate.CQRS.Criteria
{
    public static class Criterion
    {
        public static readonly EmptyCriterion Empty = new EmptyCriterion();

        public static IdCriterion<TIdType> Id<TIdType>(TIdType id)
        {
            return new IdCriterion<TIdType>(id);
        }

        public static IdListCriterion<TIdType> IdList<TIdType>(params TIdType[] idList)
        {
            return new IdListCriterion<TIdType>(idList);
        }
    }
}