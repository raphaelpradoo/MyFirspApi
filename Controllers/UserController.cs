using Microsoft.AspNetCore.Mvc;
using MyFirspApi.Communication.Request;
using MyFirspApi.Communication.Responses;

namespace MyFirspApi.Controllers;
public class UserController : MyFirstApiBaseController // Classe herda funções e propriedades da classe MyFirstApiBaseController
{
    [HttpGet] // Indica qual é o tipo da função
    [Route("{id}")] // Define o parâmetro "id" na rota da URL
    // [ProducesResponseType(StatusCodes.Status204NoContent)] // Indica qual é o tipo de resposta da função e o Status Code
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)] // Indica que o tipo de resposta da função é a classe Response e o Status Code
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    // public IActionResult Get(int id) 
    //public IActionResult Get([FromHeader] int id, [FromHeader] string? nickname) // Passando parametros pelo header
    public IActionResult GetById([FromRoute] int id)
    {
        var response = new User
        {
            Id = 1,
            Age = 35,
            Name = "Raphael"
        };
        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterUserJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterUserJson request)
    {
        var response = new ResponseRegisterUserJson
        {
            Id = 1,
            Name = request.Name,
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromBody] RequestUpdateUserProfileJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] int id)
    {
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
    public IActionResult GetAll() 
    {
        var response = new List<User>()
        {
            new User { Id = 1, Age = 35, Name = "Raphael" },
            new User { Id = 2, Age = 35, Name = "Mônica" },
            new User { Id = 3, Age = 0, Name = "Malu" },
        };

        var key = GetCustomKey();

        return Ok(key);
    }

    [HttpPut("change-password")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult ChangePassword([FromBody] RequestChangePasswordJson request)
    {
        return NoContent();
    }
}
