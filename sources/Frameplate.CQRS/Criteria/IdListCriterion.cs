namespace Frameplate.CQRS.Criteria
{
    public class IdListCriterion<TIdType> : ICriterion
    {
        public IdListCriterion(params TIdType[] idList)
        {
            IdList = idList;
        }

        public TIdType[] IdList { get; }
    }
}