using demo_graphql.Models;

namespace demo_graphql.Mocks;

public static class MockUser
{
    public static List<User> GetUsers(int length = 10)
    {
        var list = new List<User>();
        for (int i = 0; i < length; i++)
        {
            list.Add(GetUser());
        }
        return list;
    }
    public static User GetUser()
    {
        return new User
        {
            UserID = MockUtility.RandomNumber(3),
            UserName = MockUtility.RandomString(13),
            Password = MockUtility.RandomString(16),
            Email = MockUtility.RandomString(7) + "@gmail.com",
        };
    }
}