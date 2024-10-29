using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace ігри.Pages.Shared
{
    public class MainModel : PageModel
    {
        public IActionResult OnGetGoToLogin()
        {
            return RedirectToPage("/signin");
        }

        public IActionResult OnGetGoToSignUp()
        {
            return RedirectToPage("/register");
        }
    }

}
