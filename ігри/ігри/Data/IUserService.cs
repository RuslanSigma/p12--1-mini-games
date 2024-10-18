namespace ігри.Data
{
    public interface IUserService
    {
        void RegisterUser(string username, string password, string achievements, string url);
    }
}
