using FirstCoreAPI.Models;
using FirstCoreAPI.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FirstCoreAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();  // MVC pattern.
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Extract the connection string from config file.
            var connectionString = builder.Configuration.GetConnectionString("CustomerDbContext");

            // Inject the DbContext.
            builder.Services.AddDbContext<CustomerDbContext>(options =>
                options.UseSqlServer(connectionString)
            );

            builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();   // MVC Pattern.

            app.Run();
        }
    }
}