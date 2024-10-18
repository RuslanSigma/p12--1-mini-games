using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System.Data.SqlClient;
using System.Diagnostics;
namespace ігри.Pages
{
    public class kwiz1Model : PageModel
    {
        [BindProperty]
        public int Score { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

            Debug.WriteLine($"Received score: {Score}");


            return RedirectToPage();
        }
    }
}