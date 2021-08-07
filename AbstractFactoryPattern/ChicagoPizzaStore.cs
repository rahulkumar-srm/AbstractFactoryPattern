using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory pizzaIngredientFactory = new ChicagoPizzaIngredientFactory();

            if (type.Equals("Cheese"))
            {
                pizza = new CheesePizza(pizzaIngredientFactory)
                {
                    Name = "Chicago Style Cheese Pizza"
                };
            }
            else if (type.Equals("Clam"))
            {
                pizza = new ClamPizza(pizzaIngredientFactory)
                {
                    Name = "Chicago Style Clam Pizza"
                };
            }

            return pizza;
        }
    }
}
