using ContossoPizza.Models;
using ContossoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContossoPizza.Controllers;

/// <summary>
/// JEZ:  Controller to handle request
/// </summary>
[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    /// <summary>
    /// Default constructor
    /// </summary>
    public PizzaController()
    {

    }


    /// <summary>
    /// GET All Action
    /// </summary>
    /// <returns>List of Pizza objects</returns>
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll()
    {
        return PizzaService.GetAll();
    }

    /// <summary>
    /// JEZ: GET by Id action
    /// </summary>
    /// <param name="id">ID of pizza objet record</param>
    /// <returns>Pizza based on ID passed</returns>
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        var pizza = PizzaService.Get(id);

        if (pizza == null)
        {
            return NotFound();
        }

        return pizza;
    }

    /// <summary>
    /// JEZ:  POST action - Creates new pizza record
    /// </summary>
    /// <param name="pizza">Pizza to be saved</param>
    /// <returns>Result of POST action</returns>
    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {
        // Add pizza to data context
        PizzaService.Add(pizza);
        // Get HTTP result after adding pizza
        return CreatedAtAction(nameof(Get), new { id = pizza.Id }, pizza);
    }

    /// <summary>
    /// JEZ:  PUT action - updates pizza
    /// </summary>
    /// <param name="id">Record of Pizza object to be updated</param>
    /// <param name="pizza">Pizza record to be saved</param>
    /// <returns>Result of action</returns>
    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza)
    {
        // JEZ: check to see if pizza cannot be located in data context
        // (Added parenthesis as a safety measure.  Too many bad experiences with single-line if)
        if (id != pizza.Id)
        {
            return BadRequest();
        }

        // JEZ:  Get existing pizza
        var existingPizza = PizzaService.Get(id);
        // JEZ:  Do another check to see if we got the pizza...
        if (existingPizza is null)
            return NotFound();

        // JEZ:  Update the pizza...
        PizzaService.Update(pizza);

        // JEZ: retuns nothing...? I might return an indication the record was
        // updated, but I might be missing the point...
        return NoContent();
    }


    /// <summary>
    /// JEZ:  DELETE action - removes record from data context
    /// </summary>
    /// <param name="id">ID of record to be removed</param>
    /// <returns>Result of action</returns>
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        // JEZ:  Try to find record in question
        var pizza = PizzaService.Get(id);

        // JEZ:  If not found, then return NotFound result
        if (pizza is null)
            return NotFound();

        // JEZ: Remove pizza from data context
        PizzaService.Delete(id);

        // JEZ:  Again with the no content, but okay I guess...
        return NoContent();
    }

}