using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movie_extension;

namespace FilmDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mov = new War();
            var rom = new Romance();
            var act = new Movie_extension.Action();
        start:
            Console.WriteLine("Genre");
            Console.WriteLine("......................");
            Console.WriteLine("1.War");
            Console.WriteLine("2.Romance");
            Console.WriteLine("3.Action");
            Console.WriteLine("Enter Choice:");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Movie Name:");
            String movie_name = Console.ReadLine();
            Console.WriteLine("Want to 1.Insert 2.Delete 3.Display");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (g)
            {
                case 1:
                    if (op == 1)
                    {
                        mov.Insert(movie_name);
                    }
                    if (op == 2)
                    {
                        mov.Delete(movie_name);
                    }
                        mov.Display();
                    break;
                case 2:
                    if (op == 1)
                    {
                        rom.Insert(movie_name);
                    }
                    if (op == 2)
                    {
                        rom.Delete(movie_name);
                    }
                        rom.Display();
                    break;
                case 3:
                    if (op == 1)
                    {
                        act.Insert(movie_name);
                    }
                    if (op == 2)
                    {
                        act.Delete(movie_name);
                    }
                        act.Display();
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
            Console.WriteLine("Press Y/N to continue or execute");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'y' || ch == 'Y')
            {
                goto start;
            }
            else
            {
                Console.WriteLine("Thank you for using our service");
            }
        }
    }
}
