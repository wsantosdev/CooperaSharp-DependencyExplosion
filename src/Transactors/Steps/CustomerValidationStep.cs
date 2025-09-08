using CooperaSharp_DependencyExplosion.Transactors;
using Moonad;

namespace CooperaSharp_DependencyExplosion
{
    public sealed class CustomerValidationStep(CustomerDataAccess customerDataAccess,
                                               OrderStockReservationStep next) : TransactionStepBase<OrderSubmissionBag>(next)
    {
        protected override Result<Error> ExecuteInternal(ref OrderSubmissionBag input)
        {
            try
            {
                var customer = customerDataAccess.GetById(input.Request.CustomerId);
                if (customer)
                {
                    input.Customer = customer.Get();
                    return Result<Error>.Ok();
                }

                return Result<Error>.Error(new Error($"Customer with id {input.Request.CustomerId} not found"));
            }
            catch(Exception ex)
            {
                return Rollback(new Error(ex.Message));
            }
        }

        public override Result<Error> Rollback (Result<Error> error) =>
            error;
    }
}
