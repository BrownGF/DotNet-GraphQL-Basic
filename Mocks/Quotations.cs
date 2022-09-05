using demo_graphql.Models;

namespace demo_graphql.Mocks;

public static class MockQuotation
{
    public static List<Quotation> GetQuotations(int length = 10)
    {
        var list = new List<Quotation>();
        for (int i = 0; i < length; i++)
        {
            list.Add(GetQuotation());
        }
        return list;
    }

    public static Quotation GetQuotation()
    {
        return new Quotation
        {
            CompanyID = MockUtility.RandomNumber(6),
            QuotationText = MockUtility.RandomString(20),
        };
    }
}