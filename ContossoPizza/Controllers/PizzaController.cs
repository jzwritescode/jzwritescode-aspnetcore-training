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
    public ActionResult<List<Pizza>> GetAll()
    {
        PizzaService.GetAll();
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

    // POST action

    // PUT action

    // DELETE action

}