using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Models
{
    public partial class Pizza : ObservableObject
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }

        [ObservableProperty,
            NotifyPropertyChangedFor(nameof(Amount))] // Notifica cada ver que el valor de amount cambia
        public int _cartQuantity;

        public object Amount => CartQuantity * Price;

        public Pizza Clone() => MemberwiseClone() as Pizza; // this will use for view cart page
    }
}
