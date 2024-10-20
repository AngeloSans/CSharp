using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DataStructure
{
    public class ArrayList
    {
        static void Main(string[] args)
        {
            List<String> Mochila = new List<String>();
            Mochila.Add("Pen");
            Mochila.Add("Eraser");
            Mochila.Add("Book");
            Mochila.Remove("Eraser");

            foreach (String s in Mochila)
            {
                Console.WriteLine(s);
            }
            }

    }

}