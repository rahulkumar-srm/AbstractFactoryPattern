using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("Cheese");
            Console.WriteLine("Rahul ordered a " + pizza.Name + Environment.NewLine);

            pizza = chicagoStore.OrderPizza("Cheese");
            Console.WriteLine("Raj ordered a " + pizza.Name + Environment.NewLine);

            Console.ReadKey();
        }
    }
}
