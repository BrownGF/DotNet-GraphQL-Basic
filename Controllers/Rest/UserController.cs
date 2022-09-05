using demo_graphql.Services;
using Microsoft.AspNetCore.Mvc;

namespace demo_graphql.Controllers.Rest;

[Route("users")]
public class UserController
{
    private readonly UserService _userService;
    private readonly QuotationService _quotationService;

    public UserController(UserService userService, QuotationService quotationService)
    {
        _userService = userService;
        _quotationService = quotationService;
    }

    [HttpGet]
    public List<Models.User> GetUsers()
    {
        return _userService.GetUsers();
    }

    [HttpGet("{id}")]
    public Models.User GetUser(string id)
    {
        return _userService.GetUser();
    }

    [HttpGet("{id}/quotations")]
    public List<Models.Quotation> GetQuotations()
    {
        return _quotationService.GetQuotations();
    }

    [HttpGet("{id}/quotations/{quotationId}")]
    public Models.Quotation GetQuotation()
    {
        return _quotationService.GetQuotation();
    }
}