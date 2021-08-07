using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese CreatCheese()
        {
            return new CheddarCheese();
        }

        public Clam CreateClam()
        {
            return new FrozenClams();
        }

        public Dough CreateDough()
        {
            return new ThikCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Veggies[] CreateVeggies()
        {
            Veggies[] veggies = { new Garlic(), new Onion() };
            return veggies;
        }
    }
}
