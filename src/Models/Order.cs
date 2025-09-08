namespace CooperaSharp_DependencyExplosion
{
    public sealed class Order
    {
        public Guid Id { get; } = Guid.NewGuid();
        public DateTime CreatedAt { get; } = DateTime.UtcNow;
        public Guid CustomerId { get; private init; }
        public Guid[] Products { get; private init; }

        private Order(Guid customerId, Guid[] products)
        {
            CustomerId = customerId;
            Products = products;
        }

        public static Order Create(Guid customerId, Guid[] products) =>
            new Order(customerId, products);
    }
}
