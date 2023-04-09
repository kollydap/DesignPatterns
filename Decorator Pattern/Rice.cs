using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator_Pattern
{
    public abstract class Rice
    {
        private String description = "Unknown Rice";

        public String getDescription()
        {
            return description;
        }
        public abstract double cost();
    };

    public abstract class Toppings : Rice
    {
        public abstract string getDescription();
    }

    public class ContinentalToppings : Toppings
    {
        Rice rice;
        public ContinentalToppings(Rice rice)
        {
            this.rice = rice;
        }
        public override double cost()
        {
            return rice.cost() + 0.9;
        }
        public override string getDescription()
        {
            return rice.getDescription() + "Continental Toppings";  
        }

    }

    public class JollofRice : Rice
    {
        public String description = "Jollof Rice";

        public override double cost()
        {
            return 13.90;
        }
    }

}
