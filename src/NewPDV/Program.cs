using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NewPDV.Domain.Interfaces;
using NewPDV.Domain.Interfaces.Repositories;
using NewPDV.Domain.Services;
using NewPDV.Infrastructure.Context;
using NewPDV.Infrastructure.Repositories;
using System.Configuration;

namespace NewPDV
{
    internal static class Program
    {
        public static IConfiguration Configuration { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Sem ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration(config =>
                {
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((context, services) =>
                {
                    var connectionString = context.Configuration.GetConnectionString("DefaultConnection");

                    services.AddDbContext<NewPDVContext>(options =>
                        options.UseSqlServer(connectionString));

                    //Injection dependency container
                    services.AddScoped<IProductRepository, ProductRepository>();
                    services.AddScoped<IEventRepository, EventRepository>();
                    services.AddScoped<IProductService, ProductService>();
                    services.AddScoped<IEventService, EventService>();
                    services.AddScoped<ISaleService, SaleService>();

                    services.AddTransient<App>();
                })
                .Build();

            var form = host.Services.GetRequiredService<App>();
            Application.Run(form);
        
        }
    }
}