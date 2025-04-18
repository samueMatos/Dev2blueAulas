using Microsoft.AspNetCore.Mvc;
using orcamentor.api.Controllers.Objects;
using orcamentor.api.Model.Repository.Interfaces;

namespace orcamentor.api.Controllers;

[ApiController]
public class AuthController : ControllerBase
{

    private readonly IContatoRepository _repository;

    public AuthController(IContatoRepository repository)
    {
        _repository = repository;
    }

    [HttpPost("api/auth")]
    public IActionResult login([FromBody] LoginRequest loginRequest)
    {
        try
        {
            var login = _repository.Login(loginRequest).Result;
            return Ok(new LoginResponse() { Token = login.Id.ToString() });
        }
        catch (Exception e)
        {
            return ValidationProblem(new ValidationProblemDetails() { Detail = e.Message });
        }
    }

}