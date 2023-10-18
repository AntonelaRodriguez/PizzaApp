using PizzaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Services
{
    public class PizzaService
    {
        private readonly static IEnumerable<Pizza> _pizzas = new List<Pizza>
        {
            new Pizza
            {
                Name = "Pizza 1",
                Image = "pizza1img",
                Price = 2500
            },
            new Pizza
            {
                Name = "Pizza 2",
                Image = "pizza2img",
                Price = 3000
            },
            new Pizza
            {
                Name = "Pizza 3",
                Image = "pizza3img",
                Price = 1999
            },
            new Pizza
            {
                Name = "Pizza 4",
                Image = "pizza4img",
                Price = 2799
            },
            new Pizza
            {
                Name = "Pizza 5",
                Image = "pizza5img",
                Price = 2299
            },
            new Pizza
            {
                Name = "Pizza 6",
                Image = "pizza6img",
                Price = 2200
            },
            new Pizza
            {
                Name = "Pizza 7",
                Image = "pizza7img",
                Price = 2700
            },
            new Pizza
            {
                Name = "Pizza 8",
                Image = "pizza8img",
                Price = 1800
            },
            new Pizza
            {
                Name = "Pizza 9",
                Image = "pizza9img",
                Price = 2000
            },
            new Pizza
            {
                Name = "Pizza 10",
                Image = "pizza10img",
                Price = 4000
            },
        };
        public IEnumerable<Pizza> GetAllPizzas() => _pizzas;
        public IEnumerable<Pizza> GetPopularPizzas(int count = 6) => _pizzas.OrderBy(p => Guid.NewGuid())
            .Take(count);
        public IEnumerable<Pizza> GetPizzas(string searchTerm) =>
            string.IsNullOrWhiteSpace(searchTerm)
            ? _pizzas
            : _pizzas.Where(p => p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
    }
}
