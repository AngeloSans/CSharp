/*using Szystem;
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
            //create a hashmap
           Dictionary<String, List<String>> countries = new Dictionary<String, List<String>>();

            //Create a list of contries
            List<String> B = new List<String>()
            {
                //add countries to my list
                "Brazil",
                "Bulgaria",
                "Belgium",
                "Barbados",
                "Bolivia",
                "Bangladesh"
            };
            countries.Add("B", B);

            foreach (var regions in countries) 
            {
                Console.WriteLine("Countries: " + string.Join(", ", regions.Value));
            }

        }
    

    }
}
*/