using Microsoft.AspNetCore.Mvc;
using MyFirspApi.Entities;

namespace MyFirspApi.Controllers;
public class DeviceController : MyFirstApiBaseController
{
    [HttpGet]
    public IActionResult Get()
    {
        /*
        var laptop = new Laptop();
        var teste = laptop.Hello();
        var model = laptop.GetBrand();
        return Ok(model);
        */
        var key = GetCustomKey();

        return Ok(key);
    }
}
