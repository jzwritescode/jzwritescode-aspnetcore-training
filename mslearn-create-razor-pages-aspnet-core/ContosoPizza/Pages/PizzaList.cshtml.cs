using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
// JEZ:  Imports specific to the ContosoPizza Project
using ContosoPizza.Models;
using ContosoPizza.Services;

namespace ContosoPizza.Pages
{
    /// <summary>
    /// JEZ:  Class used to display a list of pizza
    /// </summary>
    public class PizzaListModel : PageModel
    {
        /// <summary>
        /// JEZ:  Reference to PizzaService that will be set when
        /// object is initialized...
        /// </summary>
        private readonly PizzaService _service;

        /// <summary>
        /// JEZ:  Define PizzaList - "default!" is a message to the compiler
        /// to not worry about null safety checks; will be intialized later...
        /// </summary>
        public IList<Pizza> PizzaList { get; set; } = default!;

        /// <summary>
        /// Constructor that is injected with PizzaService
        /// object...
        /// </summary>
        /// <param name="service">PizzaService object to be injected</param>
        public PizzaListModel(PizzaService service)
        {
            _service = service;
        }

        /// <summary>
        /// Method to intialize state needed for the page.
        /// </summary>
        public void OnGet()
        {
            // Get list of pizzas
            PizzaList = _service.GetPizzas();
        }
    }
}
