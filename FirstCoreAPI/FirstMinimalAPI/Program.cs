namespace FirstMinimalAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //// Extract the connection string from config file.
            //var connectionString = builder.Configuration.GetConnectionString("CustomerDbContext");

            //// Inject the DbContext.
            //builder.Services.AddDbContext<CustomerDbContext>(options =>
            //    options.UseSqlServer(connectionString)
            //);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            var summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            app.MapGet("/weatherforecast", (HttpContext httpContext) =>
            {
                var forecast = Enumerable.Range(1, 5).Select(index =>
                    new WeatherForecast
                    {
                        Date = DateTime.Now.AddDays(index),
                        TemperatureC = Random.Shared.Next(-20, 55),
                        Summary = summaries[Random.Shared.Next(summaries.Length)]
                    })
                    .ToArray();
                return forecast;
            })
            .WithName("GetWeatherForecast");

            app.MapGet("/", () =>
                "Hello there! This is a minimal API."
            );

            //// Minimal APIs simulating the FirstCoreAPI project implementation.
            #region Minimal APIs simulating the FirstCoreAPI project implementation.

            //app.MapPost("/customer", (Customer customer, ICustomerRepository<Customer> customerRepo) =>
            //{
            //    //db.Customers.Add(customer);
            //    //db.SaveChanges();
            //    customerRepo.Create(customer);
            //    // returns https://localhost:7174/customer/765
            //    return Results.Created($"/customer/{customer.Id}", customer);
            //});

            //app.MapPut("/customer/{id}", (int id, Customer customer, ICustomerRepository<Customer> repo) =>
            //{
            //    repo.Update(id, customer);
            //    return Results.NoContent();
            //});

            //app.MapDelete("/customer/{id}", (int id, ICustomerRepository<Customer> repo) =>
            //{
            //    repo.Delete(id);
            //    return Results.NoContent();
            //});

            #endregion

            app.Run();
        }
    }
}