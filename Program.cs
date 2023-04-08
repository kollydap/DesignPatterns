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
            PlayerCharacter killerGuy = new PlayerCharacter();
            Gunman gunman = new Gunman();
            ArrowMan man = new ArrowMan();
            man.DoStrike();
            Distributor distributor = new Distributor();
            Collectors collectors = new Collectors();
            distributor.AddCollector(collectors);
            distributor.NotifyCollectors();

            Console.ReadLine();
        }
    }
}
