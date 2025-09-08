using Moonad;

namespace CooperaSharp_DependencyExplosion
{
    public class OrderPersistenceStep(OrderAuditStep next) : TransactionStepBase<OrderSubmissionBag>(next)
    {
        protected override Result<Error> ExecuteInternal(ref OrderSubmissionBag input) =>
            //Fake persisting order
            Result<Error>.Ok();

        public override Result<Error> Rollback(Result<Error> error) =>
            error;
    }
}
