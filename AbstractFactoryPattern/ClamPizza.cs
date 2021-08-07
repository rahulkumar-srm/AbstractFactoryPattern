using AbstractFactoryPattern.Interfaces;
using System;

namespace AbstractFactoryPattern
{
    internal class ClamPizza : Pizza
    {
        public PizzaIngredientFactory pizzaIngredientFactory;

        public ClamPizza(PizzaIngredientFactory pizzaIngredientFactory)
        {
            this.pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = pizzaIngredientFactory.CreateDough();
            Sauce = pizzaIngredientFactory.CreateSauce();
            Veggies = pizzaIngredientFactory.CreateVeggies();
            Clam = pizzaIngredientFactory.CreateClam();
        }
    }
}