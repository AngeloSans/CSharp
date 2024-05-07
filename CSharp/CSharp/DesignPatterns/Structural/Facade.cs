using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Structural
{   public class InvetorySytem
    {
        public bool Check(String product)
        {
            Console.WriteLine("Checking wheter this product has on invetory");
            return true;

        }
    }
    public class Payment
    {
        public void ProcessPayment(String product, decimal amount)
        {
            Console.WriteLine($"Processing paymento to product {product} by amount of {amount}");
        }
    }
    public class OrderConfirm
    {
        public void ConfirmOrder(String product)
        {
            Console.WriteLine("Order checked");

        }
    }
    public class Facade
    {
        private InvetorySytem invetorySytem;
        private Payment payment;
        private OrderConfirm orderConfirm;

        public Facade()
        {
            invetorySytem = new InvetorySytem();
            payment = new Payment();
            orderConfirm = new OrderConfirm();
        }
        public void PlaceOrder(String product, decimal amount)
        {
            if (invetorySytem.Check(product))
            {
                payment.ProcessPayment(product, amount);
                orderConfirm.ConfirmOrder(product);
                Console.WriteLine("pedido relizado com sucesso!");
            }
            else
            {
                Console.WriteLine("pedido negado");
            }
        }
    }

}
