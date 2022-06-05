using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Assignment
{
    internal class UC2_DIceRoll
    {
        static void Main(string[] args)
        {
            const int playerOne = 1;
            int positionOne = 0;
            Random random = new Random();
            int dieRoll = random.Next(1, 7);
            Console.WriteLine("Die Rolls: " + dieRoll);
        }
    }
}
