namespace demo_graphql.Models;

public class Order
{
    public string OrderID { get; set; } = null!;
    public string CustomerID { get; set; } = null!;
    public string EmployeeID { get; set; } = null!;
    public DateTime OrderDate { get; set; }
    public DateTime RequiredDate { get; set; }
    public DateTime ShippedDate { get; set; }
}