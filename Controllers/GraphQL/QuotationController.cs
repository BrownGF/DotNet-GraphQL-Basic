namespace demo_graphql.Controllers.GraphQL;

using demo_graphql.Models;
using demo_graphql.Services;

public partial class Query {
    public async Task<List<Quotation>> GetQuotationsAsync() {
        await Task.CompletedTask;
        var service = new QuotationService();
        return service.GetQuotations();
    }
    public async Task<Quotation> GetQuotationAsync(string id) {
        await Task.CompletedTask;
        var service = new QuotationService();
        return service.GetQuotation();
    }

    public async Task<Quotation> GetQuotationWithErrorAsync(string id) {
        await Task.CompletedTask;
        throw new Exception("Not implemented");
    }
}