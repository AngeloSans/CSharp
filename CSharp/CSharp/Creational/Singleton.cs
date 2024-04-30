using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CSharp.Creational

{
    public class Singleton
    {
        private static Singleton instance;
        public Singleton() { }

        public static Singleton GetInstance()
        {
            if(instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
        public void GetConnection()
        {
            Console.WriteLine("conectando ao DB");
        }
    }
}

