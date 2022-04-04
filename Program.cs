using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj redaka");
            string BrojRedaka = Console.ReadLine();
            Console.WriteLine("Unesite broj stupaca");
            string BrojStupaca = Console.ReadLine();
            int BrojRedaka1 = Convert.ToInt32(BrojRedaka);
            int BrojStupaca1 = Convert.ToInt32(BrojStupaca);
            int redak = Convert.ToInt32( BrojRedaka) -1;
            int stupac = Convert.ToInt32(BrojStupaca) -1;
            int najmanji = 0;
            int b = 1;
            int[,] tablica = new int[BrojRedaka1,BrojStupaca1];

            //punjenje tablice

            while (redak>0) {
                // Doljnji red s desna na lijevo
                for (int i = redak; i >= najmanji; i--)
                {

                    for (int j = stupac; j >= najmanji; j--)
                    {
                        if (i == redak)
                        {
                            tablica[i, j] = b;
                            b++;
                        }

                    }


                }


                // Penjanje od gore prema dole
                for (int i = redak - 1; i >= najmanji; i--)
                {
                    for (int j = najmanji; j <= stupac; j++)
                    {
                        if (j == najmanji)
                        {
                            tablica[i, j] = b;
                            b++;
                        }
                    }
                }


                //Gornji red s lijeva na desno 
                for (int i = redak; i >= najmanji; i--)
                {
                    for (int j =najmanji + 1; j <= stupac; j++)
                    {
                        if (i == najmanji)
                        {
                            tablica[i, j] = b;
                            b++;
                        }
                    }
                }


                //Silazak od gore prema  dole 
                for (int i = najmanji + 1; i <= redak - 1; i++)
                {
                    for (int j = najmanji+1; j <= stupac; j++)
                    {
                        if (j == stupac)
                        {
                            tablica[i, j] = b;
                            b++;
                        }

                    }
                }
                redak--;
                stupac--;
                najmanji++;
            }

        
            //ispis rješenja

            for ( int i = 0; i < BrojRedaka1; i++)
            {
                Console.Write("\n");
                for ( int j = 0; j < BrojStupaca1; j++)
                {
                    Console.Write("{0}\t", tablica[i, j]);
                }
                Console.WriteLine("\n");

            }
            





        
    }
  }
}
