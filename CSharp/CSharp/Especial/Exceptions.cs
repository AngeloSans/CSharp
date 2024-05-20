using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Especial
{
    class Exceptions
    {
        static void Main(string[] args)
        {
            try 
            {
                String file = @"C:\\Users\\gabri\\Downloads\\PaperCshap.txt";
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);

                    }
                }

            } catch (FileNotFoundException ex)
            {
                Console.WriteLine("file not found");
            }
            finally
            {
                Console.WriteLine("Loading file");
            }

        }
    }
}
