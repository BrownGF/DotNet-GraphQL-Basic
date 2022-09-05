using demo_graphql.Mocks;

namespace demo_graphql.Services;

public class UserService
{
    public UserService()
    {
    }

    public List<Models.User> GetUsers()
    {
        return MockUser.GetUsers();
    }

    public Models.User GetUser()
    {
        return MockUser.GetUser();
    }
}