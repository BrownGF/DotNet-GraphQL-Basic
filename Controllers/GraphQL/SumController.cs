using demo_graphql.Controllers.Rest;

namespace demo_graphql.Controllers.GraphQL;

public class Sum {
    public List<Models.User> Users { get; set; }
    public List<Models.Quotation> Quotations { get; set; }
}

public partial class Query {

    private readonly QuotationController _quotationController;

    public Query(QuotationController quotationController)
    {
        _quotationController = quotationController;
    }
    public async Task<List<Models.User>> GetSumsAsync() {
        await Task.CompletedTask;
        return _quotationController.GetQuotations();
    }
    public async Task<Models.User> GetUserAsync(string id) {
        await Task.CompletedTask;
        var service = new Services.UserService();
        return service.GetUser();
    }

    public async Task<Models.User> GetUserWithErrorAsync(string id) {
        await Task.CompletedTask;
        throw new Exception("Not implemented");
    }
}