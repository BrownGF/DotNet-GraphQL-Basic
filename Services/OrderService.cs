using demo_graphql.Mocks;

namespace demo_graphql.Services;

public class OrderService
{
    public OrderService()
    {
    }

    public List<Models.Order> GetOrders()
    {
        return MockOrder.GetOrders();
    }

    public Models.Order GetOrder()
    {
        return MockOrder.GetOrder();
    }
}