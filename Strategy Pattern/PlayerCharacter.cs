using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy_Pattern
{
    class PlayerCharacter
    {
       public  IstrikeBehavior IstrikeBehavior;
        private int stars;

        public int PlayerStars
        {
            get { return stars; }
            set { stars = value; }
        }

        public string  PlayerName { get; set; }
        public List<String> Achievements { get; set; }

        public void DoStrike()
        {
            IstrikeBehavior.strike();
        }

    }
     public interface IstrikeBehavior
    {
        void strike(); 
    }



    class ArrowShooter : IstrikeBehavior
    {
        public void strike()
        {
            Console.WriteLine("Shoooooting Arrowsssssss!!!!");
        }
    }
    class GunShooter : IstrikeBehavior
    {
        public void strike()
        {
            Console.WriteLine("Shoooooting Bulletsss");
        }
    }




    class ArrowMan : PlayerCharacter
    {
        public ArrowMan()
        {
            IstrikeBehavior = new ArrowShooter(); 
        }
      
    }
    class Gunman : PlayerCharacter
    {
        

    }
}

