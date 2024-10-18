using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ігри.Data;

namespace ігри.Pages.User_opportunities
{
    public class RegistModel : PageModel
    {
        private readonly IUserService _userService;

        public RegistModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string Message { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                Message = "Будь ласка, заповніть усі поля.";
                return Page();
            }

            try
            {
                _userService.RegisterUser(Username, Password, "InitialAchievements", "http://defaulturl.com");
                Message = "Реєстрація успішна!";
            }
            catch (Exception ex)
            {
                Message = $"Сталася помилка: {ex.Message}";
            }

            return Page();
        }
    }
}