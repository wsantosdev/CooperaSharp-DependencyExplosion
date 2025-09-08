using Moonad;

namespace CooperaSharp_DependencyExplosion
{
    public sealed class FreightCalculationStep(OrderPaymentStep next) : TransactionStepBase<OrderSubmissionBag>(next)
    {
        protected override Result<Error> ExecuteInternal(ref OrderSubmissionBag input) =>
            //Fake calculating freight
            Result<Error>.Ok();


        public override Result<Error> Rollback(Result<Error> error) =>
            error;
    }
}
