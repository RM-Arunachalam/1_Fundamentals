using IOCExplained;

public class Program
{
    public static void Main()
    {
        // Demonstrating Inversion of Control (IoC)  [inverted object creation control from checkout constructor, here flexibility to pass any of its child class objects]
        PaymentProcessor paymentProcessor = new upi();

        // This is the core of IoC, where the dependency is injected into the Checkout class=>DI
        // Inversion of Control (IoC) allows us to change the payment method without modifying the Checkout class.(u can inject any child class object of PaymentProcessor interface)
        Checkout c =new Checkout(paymentProcessor);// Via DI
        c.MakePayment(1000);   //Calls UPI Class.ProcessPayment() [Runtime Polymorphism]

        paymentProcessor = new CreditCard();  //IOC
        // Here we are injecting a different payment method (Credit Card) without changing the Checkout class
        c = new Checkout(paymentProcessor);
        c.MakePayment(2000); 

        paymentProcessor = new DebitCard(); //IOC
        // Here we are injecting a different payment method (Debit Card) without changing the Checkout class
        c = new Checkout(paymentProcessor);
        c.MakePayment(1500);

    }
}