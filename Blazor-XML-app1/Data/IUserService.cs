namespace Blazor_XML_app1.Data
{
    public interface IUserService
    {
        List<User> SearchUsers(string input);
    }
}
