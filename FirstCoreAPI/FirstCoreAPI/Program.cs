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

            // Logger.
            //builder.Logging.AddDebug();
            //builder.Logging.AddConsole();
            //builder.Logging.SetMinimumLevel(LogLevel.Debug);

            //builder.Host.ConfigureLogging((logging) =>
            //{
            //    logging.ClearProviders();
            //    logging.AddDebug();
            //    logging.AddConsole();
            //    logging.SetMinimumLevel(LogLevel.Debug);
            //});

            //var logger = LoggerFactory.Create(config =>
            //{
            //    config.AddConsole();
            //    config.AddDebug();
            //}).CreateLogger<Program>();

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

            // Add CORS.
            #region CORS

            string client1CorsPolicy = "ClientOneOrigin";
            string client2CorsPolicy = "ClientTwoOrigin";
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: client1CorsPolicy,
                    policy =>
                    {
                        policy.WithOrigins("https://localhost:7286/,http://www.myclient.com")
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                    }
                    );

                options.AddPolicy(name: client2CorsPolicy,
                    policy =>
                    {
                        policy.WithOrigins("http://www.anotherclient.com")
                           .WithMethods("GET");
                    }
                    );
            }
            );

            #endregion

            var app = builder.Build();
            //app.Logger.Log(LogLevel.Debug, "abcd");
            //app.Logger.LogDebug(".........DEBUG..........");
            //app.Logger.LogInformation(".........INFO..........");
            //app.Logger.LogError(".........ERR..........");

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors();

            app.MapControllers();   // MVC Pattern.

            app.Run();
        }
    }
}