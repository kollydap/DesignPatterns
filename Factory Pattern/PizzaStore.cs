using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory_Pattern
{
    public abstract class Pizza
    {
        public abstract void Prepare();
        public abstract void Bake();
        public abstract void Cut();
        public abstract void box();
    }
    public class DominoPizza
    {
        SimplePizzaFactory factory;
        public DominoPizza(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }
        public DominoPizza orderPizza(String type)
        {
            DominoPizza pizza;
            pizza = factory.CreatePizza(type);
            //pizza.prepare();
            //pizza.bake();
            //pizza.cut();
            //pizza.box();
            return pizza;
        }
        public class SimplePizzaFactory
        {
            public DominoPizza CreatePizza(String type)
            {
                DominoPizza pizza = null;
                if (type == "cheese")
                {
                    //pizza = new CheesePizza();
                    Console.WriteLine("cREATE JDJ");
                    return pizza;
                }
                else if (type == "pepperoni")
                {
                    //pizza = new PepperoniPizza();
                    Console.WriteLine("cREATE JDJ");
                    return pizza;
                }
                else
                {
                    return pizza;
                }

            }
        }
    }
}
