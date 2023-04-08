using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Strategy_Pattern;
using DesignPattern.Observer_Pattern;

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

            Newspaper newspaper = new Newspaper("kolawole Is Happy", "BODY............", 123);
            Suscribers suscriber1 = new Suscribers();
            Suscribers suscriber2 = new Suscribers();
            Suscribers suscriber3 = new Suscribers();
            Suscribers suscriber4 = new Suscribers();
            //KolawoleSuscriber kolawoleSuscriber = new KolawoleSuscriber();
            //DupeSuscriber dupeSuscriber = new DupeSuscriber();
            newspaper.AddSuscribers(suscriber1);
            newspaper.AddSuscribers(suscriber2);
            newspaper.AddSuscribers(suscriber3);
            newspaper.AddSuscribers(suscriber4);
            //newspaper.AddSuscribers(kolawoleSuscriber);
            newspaper.UpdateSuscribers("helooooo", "kilooo", 583);
            Console.ReadLine();
        }
    }
}
