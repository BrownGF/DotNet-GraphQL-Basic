namespace demo_graphql.Models;

public class User {
    public string UserID { get; set; } = null!;
    public string UserName { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Role { get; set; } = null!;
    public List<Quotation> Quotations { get; set; } = new();
}