using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCExplained
{
    public interface PaymentProcessor
    {
        public void ProcessPayment(int amount);
    }

    public class upi : PaymentProcessor
    {
        public void ProcessPayment(int amount)
        {
            Console.WriteLine("Payment of " + amount + " processed through UPI.");
        }
    }
    public class CreditCard : PaymentProcessor
    {
        public void ProcessPayment(int amount)
        {
            Console.WriteLine("Payment of " + amount + " processed through Credit Card.");
        }
    }
    public class DebitCard : PaymentProcessor
    {
        public void ProcessPayment(int amount)
        {
            Console.WriteLine("Payment of " + amount + " processed through Debit Card.");
        }
    }

    //Checkout uses abstraction properly — it only knows what it needs to know (the contract/interface), and ignores how the work is actually done.
    public class Checkout
    {
        private PaymentProcessor _paymentProcessor;

        //Dependency Injection
        public Checkout(PaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void MakePayment(int amt)
        {
            //in our case the the method in checkout class just calls the interface method,no need to worry on method implementation
            //abstraction is used here, we are not concerned with how the payment is processed, just that it is processed
            _paymentProcessor.ProcessPayment(amt);
        }
    }
}

