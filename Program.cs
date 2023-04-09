using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Strategy_Pattern;
using DesignPattern.Observer_Pattern;
using DesignPattern.Decorator_Pattern;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //PlayerCharacter killerGuy = new PlayerCharacter();
            //Gunman gunman = new Gunman();
            //ArrowMan man = new ArrowMan();
            //man.DoStrike();
            //Distributor distributor = new Distributor();
            //Collectors collectors = new Collectors();
            //distributor.AddCollector(collectors);
            //distributor.NotifyCollectors();
            //Newspaper newspaper = new Newspaper();
            //Suscribers suscribers = new Suscribers();
            //Suscribers suscriber2 = new Suscribers();
            //Suscribers suscriber3 = new Suscribers();
            //Suscribers suscriber1 = new Suscribers();
            //Suscribers suscriber2 = new Suscribers();
            //Suscribers suscriber3 = new Suscribers();
            //Suscribers suscriber4 = new Suscribers();
            //KolawoleSuscriber kolawoleSuscriber = new KolawoleSuscriber();
            //DupeSuscriber dupeSuscriber = new DupeSuscriber();
            //newspaper.AddSuscribers(suscriber1);
            //newspaper.AddSuscribers(suscriber2);
            //newspaper.AddSuscribers(suscriber3);
            //newspaper.AddSuscribers(suscriber4);
            //newspaper.AddSuscribers(kolawoleSuscriber);
            //newspaper.suscribersList.Count();
            //newspaper.UpdateSuscribers("helooooo", "kilooo", 583);

            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.getDescription() + " $" +beverage.cost());
            beverage = new Mocha(beverage);

            Console.WriteLine(beverage.getDescription() + " $" + beverage.cost());
            beverage = new Whip(beverage);
            Console.WriteLine(beverage.getDescription() + " $" + beverage.cost());
            //Beverage beverage2 = new DarkRoast();
            //beverage2 = new Mocha(beverage2);
            //beverage2 = new Mocha(beverage2);
            //beverage2 = new Whip(beverage2);
            //System.out.println(beverage2.getDescription()
            //+ “ $” +beverage2.cost());
            Beverage beverage3 = new HouseBlend();
            //beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            //beverage3 = new Whip(beverage3);
            //Console.WriteLine(beverage3.getDescription() +  "$" +beverage3.cost());
            IPizza pizza = new PlainPizza();

            // Add cheese to the pizza
            pizza = new CheeseDecorator(pizza);


            Console.WriteLine("Description: " + pizza.GetDescription());
            Console.WriteLine("Price: " + pizza.GetPrice().ToString("C2"));

            Student student1 = new Student(new LinearSearchStudent());
            student1.performSearch();
            Student student2 = new Student(new BinarySearchStudent());
            student2.performSearch();

            //Rice jollofRice = new JollofRice();
            //jollofRice = new ContinentalToppings(jollofRice);
            //Console.WriteLine(jollofRice.cost());
            //Console.WriteLine(jollofRice.getDescription());
            //jollofRice = new ContinentalToppings(jollofRice);
            //Console.WriteLine(jollofRice.cost());
            //Console.WriteLine(jollofRice.getDescription());

            Hotel hotel1 = new ExecutiveRoom();
            Console.WriteLine(hotel1.cost());
            hotel1 = new Premium(hotel1);
            Console.WriteLine(hotel1.cost());
            Console.ReadLine();
        }
    }
}
