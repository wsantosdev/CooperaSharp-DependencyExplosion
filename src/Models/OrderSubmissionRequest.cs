namespace CooperaSharp_DependencyExplosion
{
    public sealed record OrderSubmissionRequest(Guid CustomerId, Guid[] Products, string ShippingAddress);
}
