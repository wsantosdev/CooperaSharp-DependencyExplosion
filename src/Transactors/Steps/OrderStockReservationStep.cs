using Moonad;

namespace CooperaSharp_DependencyExplosion
{
    public sealed class OrderStockReservationStep(FreightCalculationStep next) : TransactionStepBase<OrderSubmissionBag>(next)
    {
        protected override Result<Error> ExecuteInternal(ref OrderSubmissionBag input) =>
            //Fake reserving stock
            Result<Error>.Ok();

        public override Result<Error> Rollback(Result<Error> error) =>
            //Fake release reserved stock
            error;
    }
}
