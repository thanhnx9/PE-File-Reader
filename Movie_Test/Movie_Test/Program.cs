using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Test
{
    class Program
    {
        static double overrall_rating(string cate, string[] Cate, int acting,int music, int cinematography, int plot, int duration)
        {
            double overrall = 0;
            if (String.Compare(cate, Cate[0], true) == 0)
            {
                double action_rate = (double) (acting * 25 + music * 15 + cinematography * 20
                                     + plot * 30 + duration * 10) / 100;
                overrall = Math.Round(action_rate,0);
            }
            else if (String.Compare(cate, Cate[1], true) == 0)
            {
                double romance_rate = (double) (acting * 20 + music * 20 + cinematography * 20
                                   + plot * 30 + duration * 10) / 100;
                Console.WriteLine("{0}", romance_rate);
                overrall = Math.Round(romance_rate,0);
            }
            else if (String.Compare(cate, Cate[2], true) == 0)
            {
                double super_hero = (double) (acting * 15 + music * 15 + cinematography * 30
                                + plot * 30 + duration * 10) / 100;
                overrall = Math.Round(super_hero,0);
            }
            else if (String.Compare(cate, Cate[3], true) == 0)
            {
                double other =(double) (acting + music + cinematography
                           + plot + duration) * 20 / 100;
                overrall = Math.Round(other,0);
            }
            return overrall;
        }
        static void Main(string[] args)
        {   Movie movie = new Movie();
            while (true)
            {
                Console.Write("Movie Title:");
                movie.title = Console.ReadLine();

                Console.Write("Year released:");
                movie.year = Console.ReadLine();

                Console.Write("Publisher:");
                movie.publisher = Console.ReadLine();

               B1: Console.Write("Length:");
               try
                {
                    movie.length = int.Parse(Console.ReadLine());
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.GetType());
                    goto B1;
                }
                Console.WriteLine("Enter category of movie: {0} , {1} , {2} , {3}", movie.Category);

                Console.Write("Category:");
                string category = Console.ReadLine();
              
                do
                {
                    Console.WriteLine("Please rating from 0 to 5");
                    Console.Write("Rate the acting:");
                    movie.acting = int.Parse(Console.ReadLine());
                    Console.Write("Rate the music:");
                    movie.music = int.Parse(Console.ReadLine());
                    Console.Write("Rate the cinematography:");
                    movie.cinematography = int.Parse(Console.ReadLine());
                    Console.Write("Rate the plot:");
                    movie.plot = int.Parse(Console.ReadLine());
                    Console.Write("Rate the duration:");
                    movie.duration = int.Parse(Console.ReadLine());
                } while (movie.acting > 5 || movie.music > 5 || movie.plot > 5
                       || movie.cinematography > 5 || movie.duration > 5);

                double overrall=overrall_rating(category, movie.Category, movie.acting, movie.music,
                                movie.cinematography, movie.plot, movie.duration);
                Console.Write("Overall rating: {0}/10", overrall);
                for (int j = 0; j < overrall; j++) Console.Write("*");
                Console.Write("\n");
                Console.WriteLine("Do yo want to add the movie (Y/N):");
                string test = Console.ReadLine();
                if (String.Compare(test, "N", true) == 0) Environment.Exit(0);
                else continue;
            }
            Console.ReadKey();
        }
    }
}
