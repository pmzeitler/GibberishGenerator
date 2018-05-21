using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GibberishGenerator
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            int iterations = 0;
            if (args.Length >= 1)
            { 
                String iterationsIn = args[0];
                if (Int32.TryParse(iterationsIn, out iterations))
                {
                    for (int i = 0; i < iterations; i++)
                    {
                        Console.WriteLine(Syllables.getWord());
                    }
                }
            }
            else
            {
                Console.WriteLine(Syllables.getWord());
            }
            //Console.ReadLine();
        }
    }
}
