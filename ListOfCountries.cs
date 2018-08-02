using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace Lab16
{
    class ListOfCountries
    {
        public static string Input;
        private static string _path = @"CountryValidation.txt";





        public static bool ValidateCountry(string input )
        {
            List<string> listCountries = File.ReadLines(_path).ToList();

            if (listCountries.Contains(input.Trim()))
            {
                return true;

            }

            return false;
        }
    }
}


/*  using (StreamReader sr = File.OpenText(_path))
            {
                while (true)
                {
                    var test = sr.ReadLine();
                    if (!(test == input))
                    {
                        
                    }

                    if (test == null)
                    {
                        Console.WriteLine("thats not a country");
                        break;
                    }

                    if (test == input)
                    {

                        if (!File.Exists(_path))
                            using (StreamWriter sw = File.CreateText(_path))
                            {
                                File.WriteAllText(_path, input);
                            }

                        File.AppendAllText(_path, input);
                    }
                }
            } */
