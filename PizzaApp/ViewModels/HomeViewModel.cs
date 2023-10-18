using CommunityToolkit.Mvvm.ComponentModel;
using PizzaApp.Models;
using PizzaApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        private readonly PizzaService _pizzaService;
        public HomeViewModel(PizzaService pizzaService)
        {
            _pizzaService = pizzaService;
            Pizzas = new(_pizzaService.GetPopularPizzas());
        }

        public ObservableCollection<Pizza> Pizzas { get; set; }
    }
}
