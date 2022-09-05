using demo_graphql.Models;
using demo_graphql.Services;

namespace demo_graphql.Controllers.GraphQL;

public partial class Query {
    public async Task<List<User>> GetUsersAsync() {
        await Task.CompletedTask;
        var service = new UserService();
        var users = service.GetUsers();

        // Get Quotations
        users = users.ConvertAll(user => { user.Quotations = new QuotationService().GetQuotations(); return user; });

        // Get Order's Quotations
        users = users.ConvertAll(user => {
            user.Quotations.ConvertAll(quotation => { quotation.Orders = new OrderService().GetOrders(); return quotation; });
            return user;
        });
        return users;
    }
    public async Task<User> GetUserAsync() {
        await Task.CompletedTask;
        var service = new UserService();
        var user = service.GetUser();
        user.Quotations = new QuotationService().GetQuotations();
        user.Quotations.ConvertAll(quotation => { quotation.Orders = new OrderService().GetOrders(); return quotation; });
        return user;
    }
}