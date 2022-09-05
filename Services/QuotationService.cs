using demo_graphql.Mocks;

namespace demo_graphql.Services;

public class QuotationService
{
    public QuotationService()
    {
    }

    public List<Models.Quotation> GetQuotations()
    {
        return MockQuotation.GetQuotations();
    }

    public Models.Quotation GetQuotation()
    {
        return MockQuotation.GetQuotation();
    }
}