using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator_Pattern
{
    //Abstract Component
    public abstract class Beverage
    {
        public String description = "Unknown Beverage";

        public String getDescription()
        {
            return description;
        }
        public abstract double cost();
    }

    //Abstract decorator 
    public abstract class CondimentDecorator : Beverage
    {
        public abstract String getDescription();
    }

    //Concrete Component
    public class Espresso : Beverage
    {

        public Espresso()
        {
            description = "Espresso";
        }

        public override double cost()
        {
            return 1.99;
        }
    }

    //Concrete Component
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }
        public override double cost()
        {
            return .89;
        }
    }
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override String getDescription()
        {
            return beverage.getDescription() + ", Mocha";
        }
        public override double cost()
        {
            return .20 + beverage.cost();
        }
    }
    public class Soy : CondimentDecorator
    {
        Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override String getDescription()
        {
            return beverage.getDescription() + ", Soy";
        }
        public override double cost()
        {
            return .90 + beverage.cost();
        }
    }
    public class Whip : CondimentDecorator
    {
        Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override String getDescription()
        {
            return beverage.getDescription() + ", Whip";
        }
        public override double cost()
        {
            return 1 + beverage.cost();
        }
    }
}
