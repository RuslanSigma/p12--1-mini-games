using Microsoft.EntityFrameworkCore;
using static ігри.Pages.User_opportunities.MyDbContent;

namespace ігри.Pages.User_opportunities
{
    public class MyDbContent: DbContext
    {

        
            public DbSet<FileModel> Files { get; set; }

            //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            //{
            //    optionsBuilder.UseSqlServer(@"Server=your_server;Database=your_database;User ID=your_user;Password=your_password;");
            //}
    }
}
