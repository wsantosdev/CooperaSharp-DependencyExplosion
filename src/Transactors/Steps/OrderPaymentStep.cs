using Moonad;

namespace CooperaSharp_DependencyExplosion
{
    public sealed class OrderPaymentStep(OrderPersistenceStep next) : TransactionStepBase<OrderSubmissionBag>(next)
    {
        
        protected override Result<Error> ExecuteInternal(ref OrderSubmissionBag input) =>
            //Fake processing payment
            Result<Error>.Ok();

        public override Result<Error> Rollback(Result<Error> error) =>
            //Fake refund payment
            error;
    }
    {
    }
}
