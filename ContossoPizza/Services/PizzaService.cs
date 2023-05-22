using System.Linq;                      // JEZ:  Needed?
using ContossoPizza.Models;


namespace ContossoPizza.Services;

public static class PizzaService
{
    static List<Pizza> Pizzas { get; }
    static int nextId = 3;

    /// <summary>
    /// Default Constructor
    /// </summary>
    static PizzaService()
    {
        Pizzas = new List<Pizza>
        {
            new Pizza { Id = 1, Name = "Classic Italian", IsGlutenFree = false },
            new Pizza { Id = 2, Name = "Veggie", IsGlutenFree = true }
        };
    }

    public static List<Pizza> GetAll()
    {
        return Pizzas;
    }

    public static Pizza? Get(int id)
    {
        // JEZ:  Make sure it's the local Pizzas list...Otherwise, fun
        // compiler errors shall ensue...
        return Pizzas.FirstOrDefault<Pizza>(p => p.Id == id);
    }

    public static void Add(Pizza pizza)
    {
        pizza.Id = nextId++;
        Pizzas.Add(pizza);
    }

    public static void Delete(int id)
    {
        var pizza = Get(id);

        if (pizza is null)
        {
            return;
        }

        // Toss this pizza (pun intended?)
        Pizzas.Remove(pizza);
    }

    public static void Update(Pizza pizza)
    {
        var index = Pizzas.FindIndex(p => p.Id == pizza.Id);

        if (index == -1)
        {
            return;
        }

        Pizzas[index] = pizza;
    }
}