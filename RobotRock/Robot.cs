using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotRock
{
    public abstract class Robot
    {
        public int tempo;
        public bool isPlaying;
        protected Random rnd = new Random();
        protected int charge;
        public string name;
        protected double version;

        protected virtual void Recharge()
        {
            Console.WriteLine("Plugs in and charges");
            charge = 100;
        }
        protected virtual bool ExpendEnergy()
        {
            if (charge <= 0)
            {
                Console.WriteLine("Robot does not have enough charge to complete task");
                return false;
            }
            else
            {
                charge -= 10;
                return true;
            }
        }
        protected virtual void ReportStatus()
        {
            Console.WriteLine($"Charge status: {charge} percent. \n Name: {name} \n Version: {version}");
        }

    }
}
