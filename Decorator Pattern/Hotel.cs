using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator_Pattern
{
    public abstract class Hotel
    {
        private String description;

        public String Getdescription
        {
            get { return description; }
            set { description = value; }
        }

        public abstract double cost();

    }

    public abstract class IlevelsDecorator : Hotel { 
       
        public abstract String getDescription();
    }

    public class Premium : IlevelsDecorator
    {
        Hotel hotel;
        public Premium(Hotel hotel)
        {
            this.hotel = hotel;
        }
        public override double cost()
        {
            return hotel.cost() + 09.90;
        }
        public override string getDescription()
        {
            return hotel.Getdescription + "Premium";
        }
    }

    public class ExecutiveRoom: Hotel
    {
       
        public override double cost()
        {
            return 49.00;
        }
    }
}
