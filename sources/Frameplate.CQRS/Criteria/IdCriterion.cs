namespace Frameplate.CQRS.Criteria
{
    public class IdCriterion<TIdType> : ICriterion
    {
        public IdCriterion(TIdType id)
        {
            Id = id;
        }

        public TIdType Id { get; }
    }
}