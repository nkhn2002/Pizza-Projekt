using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza_Projekt
{
    public class Pizza
    {
        private int pizzaid;
        private string name;
        private float price;
        private string toppings;

        public int PizzaID
        {
            get { return pizzaid; }
            set { pizzaid = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Toppings
        {
            get { return toppings; }
            set { toppings = value; }
        }

        public Pizza(int _id, string _name, string _toppings, float _price)
        {
            pizzaid = _id;
            name = _name;
            toppings = _toppings;
            price = _price;
        }
    }
}