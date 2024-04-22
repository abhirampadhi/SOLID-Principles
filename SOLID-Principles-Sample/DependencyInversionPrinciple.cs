// Bad example violating DIP
public class DataAccess
{
    public void SaveData(string data)
    {
        // Code to save data to a specific database
    }
}

public class UserService
{
    private readonly DataAccess _dataAccess;

    public UserService()
    {
        _dataAccess = new DataAccess();
    }

    public void CreateUser(string username, string password)
    {
        // Code to create a user

        _dataAccess.SaveData("User created: " + username);
    }
}

// Good example following DIP
public interface IDataAccess
{
    void SaveData(string data);
}

public class DataAccess : IDataAccess
{
    public void SaveData(string data)
    {
        // Code to save data to a specific database
    }
}

public class UserService
{
    private readonly IDataAccess _dataAccess;

    public UserService(IDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }

    public void CreateUser(string username, string password)
    {
        // Code to create a user

        _dataAccess.SaveData("User created: " + username);
    }
}