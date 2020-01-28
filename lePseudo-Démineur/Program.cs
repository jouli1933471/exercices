
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lePseudo_Démineur
{
    class Program
    {
        static void AfficherTableau1(ref int[,] tab1)
        {
            int hauteur = 5;
            int largeur = 5;

            for(int i = 0;i<hauteur;i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                   if(tab1[i,j] == -1)
                   {
                        Console.Write("M");
                   }
                   else
                   {
                        Console.Write(tab1[i, j]);
                   }
                }
                Console.WriteLine("");
            }
        }
        static void AfficherTableau2(ref int[,] tab2)
        {
            Console.Clear();
            int hauteur = 5;
            int largeur = 5;

            for (int i = 0; i < hauteur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    if (tab2[i, j] == 1 || tab2[i, j] == 2 || tab2[i, j] == -1)
                    {
                        Console.Write("*");
                    }
                    else 
                    {
                        Console.Write(tab2[i,j]-10);
                    }
                }
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            int[,] tab1 = new int[,]
            {
                {1,2,1,1,0},
                {-1,2,-1,1,0},
                {1,2,1,1,0},
                {1,1,1,0,0},
                {1,-1,1,0,0}
            };
            int[,] tab2 = new int[,]
            {
                {1,2,1,1,10},
                {-1,2,-1,1,10},
                {1,12,1,1,10},
                {1,1,1,10,10},
                {11,-1,1,10,10}
            };
            AfficherTableau1(ref tab1);
            Console.ReadKey();
            AfficherTableau2(ref tab2);
            Console.ReadKey();
        }
    }
}
