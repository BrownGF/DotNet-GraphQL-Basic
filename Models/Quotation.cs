namespace demo_graphql.Models;

public class Quotation
{
    public string CompanyID { get; set; } = null!;
    public string QuotationText { get; set; } = null!;
    public List<Order> Orders { get; set; } = new();
}