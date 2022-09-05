namespace demo_graphql.Mocks;

public static class MockOrder
{
    public static List<Models.Order> GetOrders(int length = 10)
    {
        var list = new List<Models.Order>();
        for (int i = 0; i < length; i++)
        {
            list.Add(GetOrder());
        }
        return list;
    }

    public static Models.Order GetOrder()
    {
        return new Models.Order
        {
            OrderID = MockUtility.RandomNumber(3),
            CustomerID = MockUtility.RandomNumber(3),
            EmployeeID = MockUtility.RandomNumber(3),
            OrderDate = DateTime.Now,
            RequiredDate = DateTime.Now,
            ShippedDate = DateTime.Now,
        };
    }
}