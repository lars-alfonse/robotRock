using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotRock
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDrummerName;
            string firstGuitaristName;
            int numberOfDrummers;
            int numberOfGuitarists;
            List<Robot> band = new List<Robot>();
            List<DrumMachine> drummers = new List<DrumMachine>();
            List<GuitarBot> guitarists = new List<GuitarBot>();
            Console.WriteLine("How many drummers would you like?");
            numberOfDrummers = int.Parse(Console.ReadLine());
            Console.WriteLine("How many Guitarist would you like?");
            numberOfGuitarists = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfDrummers; i++)
            {
                DrumMachine drummer = new DrumMachine();
                drummers.Add(drummer);
                band.Add(drummer);
            }
            for (int j = 1 ; j <= numberOfGuitarists; j++)
            {
                GuitarBot guitarist = new GuitarBot();
                guitarists.Add(guitarist);
                band.Add(guitarist);
            }
            Console.WriteLine("Here are your Drummers: ");
            foreach(DrumMachine drummer in drummers)
            {
                Console.WriteLine($"{drummer.name}");
            }
            //Console.WriteLine("Which will be first?");
            //firstDrummerName = Console.ReadLine();
            Console.WriteLine("Here are your guitarists");
            foreach(GuitarBot guitarist in guitarists)
            {
                Console.WriteLine($"{guitarist.name}");
            }
            //Console.WriteLine("Which will be first?");
            //firstGuitaristName = Console.ReadLine();
            Console.WriteLine($"Nice job Choosing your bots. Let's start jamming \n ");
            foreach(GuitarBot guitarist in guitarists)
            {
                guitarist.StartStrumming(band);
            }
            foreach(DrumMachine drummer in drummers)
            {
                drummer.StartDrumming(band);
            }
            Console.WriteLine("This song is sweet");
            Console.ReadLine();
        }
    }
}
