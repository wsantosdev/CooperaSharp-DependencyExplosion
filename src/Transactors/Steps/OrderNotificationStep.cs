using Moonad;

namespace CooperaSharp_DependencyExplosion
{
    public sealed class OrderNotificationStep() : TransactionStepBase<OrderSubmissionBag>(null)
    {
        protected override Result<Error> ExecuteInternal(ref OrderSubmissionBag input) =>
           //Fake sending notification
            Result<Error>.Ok();

        public override Result<Error> Rollback(Result<Error> error) =>
            error;
    }
}