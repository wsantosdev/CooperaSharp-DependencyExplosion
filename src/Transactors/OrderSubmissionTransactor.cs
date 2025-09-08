using Moonad;

namespace CooperaSharp_DependencyExplosion
{
    public sealed class OrderSubmissionTransactor(CustomerValidationStep step)
    {
        public Result<Error> Process(OrderSubmissionBag bag) =>
            step.Execute(bag);
    }
}
