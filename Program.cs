using CustomerEvidenceApp.Data;
using CustomerEvidenceApp.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CustomerEvidenceApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            try
            {
                // Verify configuration is accessible
                var configuration = AppConfiguration.GetConfiguration();

                if (string.IsNullOrEmpty(configuration.GetConnectionString("SQLiteConnection")))
                {
                    throw new InvalidOperationException("Database connection strings are not properly configured.");
                }


                using var sqliteContext = new SQLiteDbContext();

                // Ensure database is created
                await sqliteContext.Database.EnsureCreatedAsync();

                // Configure logging
                using var loggerFactory = LoggerFactory.Create(builder =>
                {
                    builder
                        .SetMinimumLevel(LogLevel.Information);
                });

                var logger = loggerFactory.CreateLogger<DatabaseSeeder>();

                // Initialize and run seeder
                var seeder = new DatabaseSeeder(sqliteContext, logger);
                await seeder.SeedAllAsync(100);

                ApplicationConfiguration.Initialize();
                Application.Run(new CustomerListForm(sqliteContext));
            }
            catch (Exception ex) 
            { 
                MessageBox.Show($"Application initalization error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}