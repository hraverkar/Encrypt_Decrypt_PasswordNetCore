using TestRestWebApi.Model;

public interface IUserService
{
    public User GetUser(string userId);
    public bool SaveUser(User user);
}