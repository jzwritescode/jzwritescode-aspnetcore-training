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
    /// <returns></returns>
    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza)
    {
        // This code will update hte pizza and return a result
    }


    /// <summary>
    /// JEZ:  DELETE action - removes record from data context
    /// </summary>
    /// <param name="id">ID of record to be removed</param>
    /// <returns>Result of action</returns>
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        // This code wil delete the pizza and return a result
    }

}