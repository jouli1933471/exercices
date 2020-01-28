using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leBat_Signal
{
    class Program
    {
        static void analyserBatParkour(ref double VitDeplacement, double VitDescente, double hauteurMin, double hauteur, double distance)
        {
            double dCourante = 0;
            double duree = 0;

            Console.WriteLine("\n"+"vitesse de déplacement : " + VitDeplacement);
            Console.WriteLine("vitesse de descente : " + VitDescente);
            Console.WriteLine("distance : " + distance);
            Console.WriteLine("hauteur minimum : " + hauteurMin);
            Console.WriteLine("hauteur : " + hauteur);

            while(dCourante < distance)
            {
                duree = duree++;
                dCourante = dCourante + VitDeplacement;
                hauteur = hauteur-VitDescente;
            }

            Console.WriteLine("duree : " + duree +"\n" + "distance : " + distance + "\n" + "hauteur : " + hauteur);

            if(hauteur>hauteurMin + 50)
            {
                Console.WriteLine("Batman passe au-dessus du GCPD");
            }
            else if(hauteur < hauteurMin)
            {
                Console.WriteLine("Batman arrive dans le mur du GCPD");
            }
            else
            {
                Console.WriteLine("Batman atteri sur le toit");
            }
        }
        static void Main(string[] args)
        {
            double[] tabVitDeplacement = { 3, 2.5, 2, 1.5, 1};
            double[] tabVitDescente = { 8.5, 5.5, 4, 2, 1.5 };

            double hauteurMin = 50;
            double hauteur = 445;
            double distance = 168;

            for(int i = 0 ; i < tabVitDeplacement.Length ; i++)
            {
                analyserBatParkour(ref tabVitDeplacement[i],tabVitDescente[i],hauteurMin,hauteur,distance);
            }
        }
    }
}
