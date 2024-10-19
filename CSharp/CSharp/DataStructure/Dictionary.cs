using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DataStructure
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> Models = new Dictionary<String, String>();

            Models.Add("Adriana Lima", "Brazil");
            Models.Add("Alessandra Ambrosio", "Brazil");


            Console.WriteLine(Models.ContainsKey("Adriana Lima"));

            Console.WriteLine(Models.ContainsValue("Brazil"));



        }

    }
}
