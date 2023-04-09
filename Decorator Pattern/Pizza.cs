using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator_Pattern
{
    using System;

    // The interface for our component
    public interface IPizza
    {
        string GetDescription();
        decimal GetPrice();
    }

    // The implementation of our component
    public class PlainPizza : IPizza
    {
        public string GetDescription()
        {
            return "Plain pizza";
        }

        public decimal GetPrice()
        {
            return 5.99m;
        }
    }

    // The abstract decorator class
    public abstract class PizzaDecorator : IPizza
    {
        protected IPizza pizza;

        public PizzaDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public virtual string GetDescription()
        {
            return pizza.GetDescription();
        }

        public virtual decimal GetPrice()
        {
            return pizza.GetPrice();
        }
    }

    // The concrete decorator class
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return pizza.GetDescription() + ", cheese";
        }

        public override decimal GetPrice()
        {
            return pizza.GetPrice() + 1.50m;
        }
    }

    // The client code
  

}
