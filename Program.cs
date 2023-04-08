using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Strategy_Pattern;

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
            Console.ReadLine();
        }
    }
}
