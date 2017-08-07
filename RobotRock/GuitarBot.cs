using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotRock
{
    public class GuitarBot : Robot
    {
        public GuitarBot()
        {
            NameGuitarist();
            tempo = 0;
            charge = 100;
            Console.WriteLine($"{name} is charged up");
            version = 2.6;
        }
        public void NameGuitarist()
        {
            Console.WriteLine("What would you like to name your GuitarBot?");
            name = Console.ReadLine();
        }
        public void StartStrumming(List<Robot> band)
        {
                foreach (Robot musician in band)
                {
                    if (musician.tempo > 0 && isPlaying == false)
                    {
                        tempo = musician.tempo;
                        Console.WriteLine($"{name} begins shredding licks and melting faces at a pace to match {musician.name}'s tempo");
                        isPlaying = true;
                    }
                }
            if (isPlaying == false)
            {
                isPlaying = true;
                tempo = rnd.Next(100);
                Console.WriteLine($"{name} begins shredding to a tempo of {tempo}");
            }
            Console.WriteLine("WOW My face is melting");
        }

    }
}
