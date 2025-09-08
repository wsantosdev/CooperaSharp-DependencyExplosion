using Moonad;

namespace CooperaSharp_DependencyExplosion
{
    public sealed class CustomerDataAccess
    {
        public Option<Customer> GetById(Guid customerId) =>
            new Customer(customerId, "email@email.com");
    }
}
