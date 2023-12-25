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
    [HttpPost]
    public IActionResult Create(Burger burger)
    {
        BurgerService.Add(burger);
        return CreatedAtAction(nameof(Get), new { id = burger.Id }, burger);
    }

    //  PUT edit burger
    [HttpPut("{id}")]
    public IActionResult Update(int id, Burger burger)
    {
        if (id != burger.Id) return BadRequest();
        var existingBurger = BurgerService.Get(id);
        if (existingBurger is null) return NotFound();
        BurgerService.Update(burger);
        return Content($"Updated burger: {burger.Name}");
    }

    //  DELETE burger by Id
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var burger = BurgerService.Get(id);
        if (burger is null) return NotFound();
        BurgerService.Delete(id);
        return Content($"Deleted burger: {burger.Name}");
    }
}
