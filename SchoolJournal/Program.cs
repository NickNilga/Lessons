using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SchoolJournal.Repositories.Database;

namespace SchoolJournal
{
	public class Program
	{
		public static void Main(string[] args)
		{
			IHost host = new HostBuilder()
				.UseContentRoot(Directory.GetCurrentDirectory())
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseKestrel(serverOptions =>
						{
							// Set properties and call methods on options
						})
						//.UseIISIntegration()
						.ConfigureLogging((hostingContext, logging) =>
						{
							logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
							logging.AddConsole();
							logging.AddDebug();
							logging.AddEventSourceLogger();
						})
						.UseStartup<Startup>();
				})
				.Build();

			//Initialize database
			using (IServiceScope scope = host.Services.CreateScope())
			{
				IServiceProvider services = scope.ServiceProvider;
				try
				{
					SchoolDbContext context = services.GetRequiredService<SchoolDbContext>();
					context.Database.EnsureCreated();
				}
				catch (Exception ex)
				{
					var logger = services.GetRequiredService<ILogger<Program>>();
					logger.LogError(ex, "An error occurred while seeding the database.");
				}
			}

			host.Run();
		}
	}
}