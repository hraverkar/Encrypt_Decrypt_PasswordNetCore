using Dapper;
using TestRestWebApi.Contacts;
using TestRestWebApi.Data;
using TestRestWebApi.Model;

public class UserService(IEncryptionService encryptionService, DapperContext dapperContext) : IUserService
{
    private readonly IEncryptionService _encryptionService = encryptionService;
    private readonly DapperContext _dapperContext = dapperContext;

    public User GetUser(string userId)
    {
        var user = new User();
        const string query = "Select * from Users Where UserId = @userId";
        using (var connection = _dapperContext.CreateConnection())
        {
            user = connection.QueryFirstOrDefault<User>(query, new { UserId = userId });
        }
        if (user != null)
            user.Password = _encryptionService.Decrypt(user.Password);
#pragma warning disable CS8603 // Possible null reference return.
        return user;
#pragma warning restore CS8603 // Possible null reference return.
    }

    public bool SaveUser(User user)
    {
        user.Password = _encryptionService.Encrypt(user.Password);
        var result = 0;
        const string query = "Insert into Users (UserId, Name, Email, Password, Phone) Values (@UserId, @Name, @Email, @Password, @Phone)";
        using (var connection = _dapperContext.CreateConnection())
        {
            result = connection.Execute(query, user);
        }
        return result > 0;
    }
}