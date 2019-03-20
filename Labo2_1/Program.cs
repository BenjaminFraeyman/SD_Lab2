using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Labo2_1
{
    class willekeurig
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BENODIGDE TIJD: 20 minuten");

            Console.WriteLine("Getal?");
            int getal;
            getal = Convert.ToInt32(Console.ReadLine()); // input

            Random random = new Random(); // aanroep generator

            int[] getallen = new int[10]; // aanmaak array

            for (int i = 0; i < 10; i++) // array opvullen met random waardes
            {
                int getal2 = 0;               
                getal2 = random.Next(0, getal); // random nummer maken
                getallen[i] = getal2; // in array plaatsen
            }
            foreach (var item in getallen)
            {
                Console.Write(item.ToString() + " "); // array uitprinten
            }
            Console.ReadLine(); // stop
        }
    }
}
// BENODIGDE TIJD
// 20 minuten
