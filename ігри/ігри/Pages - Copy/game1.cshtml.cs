using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
 
namespace ігри.Pages
{
    public class game1Model : PageModel
    {
        public void OnGet()
        {
        }
        public class GameResult
        {
            public int Id { get; set; }
            public string PlayerName { get; set; }
            public int Score { get; set; }
            public DateTime Date { get; set; }
        }
        public class GameContext : DbContext
        {
            public DbSet<GameResult> GameResults { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("YourConnectionStringHere");
            }
            public void SaveGameResult(string playerName, int score)
            {
                using (var context = new GameContext())
                {
                    var result = new GameResult
                    {
                        PlayerName = playerName,
                        Score = score,
                        Date = DateTime.Now
                    };

                    context.GameResults.Add(result);
                    context.SaveChanges();
                }
            }
            public List<GameResult> GetTopScores(int topN)
            {
                using (var context = new GameContext())
                {
                    return context.GameResults
                        .OrderByDescending(r => r.Score)
                        .Take(topN)
                        .ToList();
                }
            }

        }
    }
}