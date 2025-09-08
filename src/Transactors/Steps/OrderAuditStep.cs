using Moonad;

namespace CooperaSharp_DependencyExplosion
{
    public sealed class OrderAuditStep(OrderNotificationStep next) :TransactionStepBase<OrderSubmissionBag>(next)
    {
        protected override Result<Error> ExecuteInternal(ref OrderSubmissionBag input) =>
            //Fake auditing order
            Result<Error>.Ok();
        public override Result<Error> Rollback(Result<Error> error) =>
            error;
    }
}
