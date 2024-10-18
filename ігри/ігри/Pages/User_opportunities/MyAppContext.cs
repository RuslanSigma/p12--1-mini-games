using Microsoft.EntityFrameworkCore;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace ігри.Pages.User_opportunities
{
    public class MyAppContext : DbContext
    {
        public DbSet<FileModel> FileModel { get; set; }

        //public MyAppContext() : base("name=MyAppContext")
        //{
        //}
    }
}
