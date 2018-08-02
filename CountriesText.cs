using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab16
{
    class CountriesText
    {
        public class CountriesTextFile
        {
            //C:\Users\scull\source\repos\Lab16\Lab16
            //streamreader new FileStream (possible solution)

            private static string _path;
           // private static string _createCountry;

            public static void ReadCountries()
            {

                _path = @"C:\Users\scull\source\repos\Lab16\Countries.txt";
                // _createCountry = "Countries";

                if (!File.Exists(_path))
                    using (StreamWriter sw = File.CreateText(_path))
                    {
                    }

                string readText = File.ReadAllText(_path);
                Console.WriteLine(readText);

            }

            public static void WriteCountries()
            {
                Console.WriteLine("Enter a country name");
                var countryName = Console.ReadLine() + Environment.NewLine;
                if (ListOfCountries.ValidateCountry(countryName))
                {
                    _path = @"C:\Users\scull\source\repos\Lab16\Countries.txt";
                    // _createCountry = "Countries";

                    if (!File.Exists(_path))
                        using (StreamWriter sw = File.CreateText(_path))
                        {
                            File.WriteAllText(_path, countryName);
                        }

                    File.AppendAllText(_path, countryName);
                }
                else
                {
                    Console.WriteLine("thats not a country");
                }
            }

            public static void CountryDeleter()
            {
                List<string> activeCountries = File.ReadLines(_path).ToList();
                Console.WriteLine("Wich country to delete?");
                int del = int.Parse(Console.ReadLine());
                activeCountries.RemoveAt(del -1);
                File.WriteAllLines(_path,activeCountries.ToArray());

            }
        }
    }
}
