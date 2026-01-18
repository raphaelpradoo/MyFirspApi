using Microsoft.AspNetCore.Mvc;

namespace MyFirspApi.Controllers;

[Route("api/[controller]")] // Definição de como será a rota para acessar o endpoint
[ApiController] // Indica que a classe é um Controller de API
public abstract class MyFirstApiBaseController : ControllerBase
{
    public string Author { get; set; } = "Raphael Souza Prado";

    protected string GetCustomKey()
    {
        return Request.Headers["MyKey"].ToString();
    }

    [HttpGet("heathy")]
    public IActionResult Heathy()
    {
        return Ok("It's working");
    }
}
