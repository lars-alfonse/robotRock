using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotRock
{
    public class DrumMachine : Robot 
    {

        public DrumMachine()
        {
            NameMachine();
            tempo = 0;
            isPlaying = false;
            Console.WriteLine($"{name} is charged up");
            charge = 100;
            version = 3.0;
        }
        public void NameMachine()
        {
            Console.WriteLine("What would you like to name your DrumMachine?");
            name = Console.ReadLine();
        }
        public void StartDrumming(List<Robot> band)
        {
            foreach (Robot musician in band)
            {
                if (musician.isPlaying && isPlaying == false)
                {
                    tempo = musician.tempo;
                    Console.WriteLine($"{name} begins dropping a dope beat matching {musician.name}'s tempo");
                    isPlaying = true;
                }
            }
               if (isPlaying == false)
                {
                    isPlaying = true;
                    tempo = rnd.Next(100);
                    Console.WriteLine($"{name} begins laying down a tempo of {tempo}");
                }
            Console.WriteLine("Those beats are dope");
        }
    }
}
