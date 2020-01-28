using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace energie_dore
{
    class Program
    {
        static void Main(string[] args)
        {
            int H2 = 0;
            int OH = 0;
            int Na2 = 0;
            int KrO3H = 0;


            Console.WriteLine("Quelle est la quantité de sodium(Na)");
            int Na = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Quelle est la quantité d'eau(H2O)");
            int H2O = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quelle est la quantité de krypton(Kr)");
            int Kr = Convert.ToInt32(Console.ReadLine());

            while(Na >= 3 && H2O >= 4)
            {
                H2 = H2+2;
                OH = OH+4;
                Na2 = Na2+2;
                Na = Na-2;
                H2O = H2O-4;
            }

            Console.WriteLine("\nPremière réaction");
            Console.WriteLine("la quantité de H2 est de "+H2);
            Console.WriteLine("la quantité de OH est de "+OH);
            Console.WriteLine("la quantité de Na2 est de "+Na2);
            Console.WriteLine("la quantité de Na est de "+Na);
            Console.WriteLine("la quantité de H2O est de "+H2O);
            Console.ReadKey();

            while(OH >= 3 && Kr >= 1)
            {
                KrO3H = KrO3H++;
                H2 = H2++;
                OH = OH-3;
                Kr = Kr-1;
            }

            Console.WriteLine("\nDeuxième réaction");
            Console.WriteLine("la quantité de OH est de "+OH);
            Console.WriteLine("la quantité de KrO3H est de "+KrO3H);
            Console.WriteLine("la quantité de Kr est de "+Kr);
            Console.WriteLine("la quantité de H2 est de "+H2);

            Console.ReadKey();
        }
    }
}
