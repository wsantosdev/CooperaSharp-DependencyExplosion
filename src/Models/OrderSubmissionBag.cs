namespace CooperaSharp_DependencyExplosion
{
    public sealed class OrderSubmissionBag
    { 
        public required OrderSubmissionRequest Request { get; set; }
        public required Customer? Customer { get; set; }
        public required Order? Order { get; set; }
    }
}
