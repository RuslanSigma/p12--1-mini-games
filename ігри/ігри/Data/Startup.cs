namespace ігри.Data
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();

            string connectionString = @"Data Source=C:\Users\ggg81\OneDrive\Робочий стіл\SQL Server Scripts1\SQL Server Scripts1\SQL Server Scripts1\SQL Server Scripts1";
            services.AddSingleton<IUserService>(new UserService(connectionString));
        }
    }
}
