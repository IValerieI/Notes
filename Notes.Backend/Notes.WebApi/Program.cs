//using Serilog;
//using Serilog.Events;
using Notes.Persistence;

namespace Notes.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Log.Logger = new LoggerConfiguration()
            //    .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            //    .WriteTo.File("NotesWebAppLog-.txt", rollingInterval:
            //        RollingInterval.Day)
            //    .CreateLogger();

            var host = CreateHostBuilder(args).Build();

            var builder = WebApplication.CreateBuilder();

            //builder.Services.AddMediatR(cfg =>
            //{
            //    cfg.RegisterServicesFromAssemblies(typeof(Startup).Assembly, typeof(YourHandler).Assembly);
            //});

            using (var scope = host.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                try
                {
                    var context = serviceProvider.GetRequiredService<NotesDbContext>();
                    DbInitializer.Initialize(context);
                }
                catch (Exception exception)
                {
                    //Log.Fatal(exception, "An error occurred while app initialization");
                    Console.WriteLine(exception);
                }
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                //.UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}