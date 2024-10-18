using Microsoft.Extensions.Configuration;

namespace ігри.Pages.User_opportunities
{
    public class Gmail
    {
        record EmailDescription(string Password);
        readonly IConfiguration configuration;
        public Gmail(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var emailconfig = new EmailDescription("");
            configuration.Bind("Email", emailconfig);
            throw new NotImplementedException();
        }
    }
}
