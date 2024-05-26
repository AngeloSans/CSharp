using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Especial
{
    class Generic
    {
        static void Main(string[] args)
        {
            Box<String> toy = new Box<String>();
            toy.addValue("Max steel");
            toy.addValue("BARBIE");
            toy.showValues();
        }
    }
    class Box<T>
    {
        private List<T> _list = new List<T>();

        public void addValue(T value)
        {
            _list.Add(value);
        }

        public void showValues()
        {
            foreach(T value in _list)
            {
                Console.WriteLine(value);
            }
        }
    }
}
