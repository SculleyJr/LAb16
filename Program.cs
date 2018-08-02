using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab16
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Would you like to read contry list (1) or write to country list (2)");

                var input = int.Parse(Console.ReadLine());
                

                switch (input)
                {
                    case 1:
                        CountriesText.CountriesTextFile.ReadCountries();
                        break;
                    case 2:
                        CountriesText.CountriesTextFile.WriteCountries();
                        break;
                    case 3:
                        CountriesText.CountriesTextFile.CountryDeleter();
                        
                        
                        
                        break;

                    case 4:
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Not valid entry");
                        break;
                }
            }

        }
    }
}
