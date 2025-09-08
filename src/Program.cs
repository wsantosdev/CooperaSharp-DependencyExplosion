namespace CooperaSharp_DependencyExplosion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddScoped<OrderSubmissionTransactor>();
            builder.Services.AddScoped<CustomerDataAccess>();
            builder.Services.AddScoped<CustomerValidationStep>();
            builder.Services.AddScoped<FreightCalculationStep>();
            builder.Services.AddScoped<OrderAuditStep>();
            builder.Services.AddScoped<OrderNotificationStep>();
            builder.Services.AddScoped<OrderPaymentStep>();
            builder.Services.AddScoped<OrderPersistenceStep>();
            builder.Services.AddScoped<OrderStockReservationStep>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
