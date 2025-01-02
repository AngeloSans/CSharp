/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DesignPatterns.Creational
{
    public class Factory
    {
        static void Main(string[] args)
        {
            FabricaDeBrinquedos fabrica = new FabricaDeBrinquedos();

            Brinquedo brinquedo1 = fabrica.criarBrinquedo("carro");
            brinquedo1.mostrarTipo();

            Brinquedo brinquedo2 = fabrica.criarBrinquedo("boneca");
            brinquedo2.mostrarTipo();

            Brinquedo brinquedo3 = fabrica.criarBrinquedo("max steels");
            brinquedo3.mostrarTipo();

        }
    }
    public abstract class Brinquedo
    {
        public abstract void mostrarTipo();
    }

    public class Carrinho : Brinquedo
    {
        public override void mostrarTipo()
        {
            Console.WriteLine("Isso é um carrinho");
        }
    }

    public class Boneca : Brinquedo
    {
        public override void mostrarTipo()
        {
            Console.WriteLine("Isso é uma Bonequinha");
        }
    }

    public class FabricaDeBrinquedos
    {
        public Brinquedo criarBrinquedo(string tipo)
        {
            if (tipo == "carro")
            {
                return new Carrinho();
            }
            if (tipo == "boneca")
            {
                return new Boneca();
            }
            else
            {
                throw new Exception("Brinquedo não existe amigo");
            }
        }
    }
}
*/