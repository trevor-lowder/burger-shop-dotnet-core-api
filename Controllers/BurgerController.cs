using BigEBurgers.Models;
using BigEBurgers.Services;
using Microsoft.AspNetCore.Mvc;

namespace BigEBurgers.Controllers;

[ApiController]
[Route("[controller]")]
public class BurgerController : ControllerBase
{
    public BurgerController()
    {

    }

    //  GET All burgers
    [HttpGet]
    public ActionResult<List<Burger>> GetAll() => BurgerService.GetAll();

    //  GET burgers by Id
    [HttpGet("{id}")]
    public ActionResult<Burger> Get(int id)
    {
        var burger = BurgerService.Get(id);
        if (burger == null) return NotFound();
        return burger;
    }

    //  POST create new burger
    //  PUT edit burger
    //  DELETE burger by Id
}
