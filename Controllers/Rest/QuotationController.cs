using Microsoft.AspNetCore.Mvc;

namespace demo_graphql.Controllers.Rest;

[Route("quotations")]
public class QuotationController : ControllerBase
{
    private readonly Services.QuotationService _quotationService;
    private readonly Services.UserService _userService;

    public QuotationController(Services.QuotationService quotationService, Services.UserService userService)
    {
        _quotationService = quotationService;
        _userService = userService;
    }

    [HttpGet]
    public IActionResult GetQuotations()
    {
        var quotations = _quotationService.GetQuotations();
        return Ok(quotations);
    }

    [HttpGet("{id}")]
    public IActionResult GetQuotation(string id)
    {
        var quotation = _quotationService.GetQuotation();
        return Ok(quotation);
    }

    [HttpGet("{id}/orders")]
    public IActionResult GetOrders(string id)
    {
        var orders = _quotationService.GetQuotation().Orders;
        return Ok(orders);
    }

    [HttpGet("{id}/orders/{orderId}")]
    public IActionResult GetOrder(string id, string orderId)
    {
        var order = _quotationService.GetQuotation().Orders.FirstOrDefault(o => o.OrderID == orderId);
        return Ok(order);
    }
}