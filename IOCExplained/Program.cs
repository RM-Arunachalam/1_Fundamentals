using IOCExplained;

//Main() decides which impl (IoC) → places it in Checkout (DI)
//Checkout calls the interface (Abstraction) → right impl runs (Runtime Polymorphism)

public class Program
{
    //Without IoC: Checkout is both the decision maker(which payment method object to create inside checkout constructor) and the worker.(make payment)
    //With IoC: Main() is the decision maker, Checkout is purely the worker.
    public static void Main()
    {
        // Demonstrating Inversion of Control (IoC)  [inverted object creation control from checkout constructor, here flexibility to pass any of its child class objects]
        IPaymentProcessor paymentProcessor = new UPI(); //injected  object

        // This is the core of IoC, where the dependency is injected into the Checkout class=>IPaymentProcessor[Dependency]

        // Inversion of Control (IoC) allows us to change the payment method without modifying the Checkout class.(u can inject any child class object of PaymentProcessor interface)
        Checkout c =new Checkout(paymentProcessor);// Via DI
        c.MakePayment(1000);   //Calls UPI Class.ProcessPayment() [Runtime Polymorphism]

        paymentProcessor = new CreditCard();  //IOC
        // Here we are injecting a different payment method (Credit Card) without changing the Checkout class
        c = new Checkout(paymentProcessor);
        c.MakePayment(1500); 

        paymentProcessor = new DebitCard(); //IOC
        // Here we are injecting a different payment method (Debit Card) without changing the Checkout class
        c = new Checkout(paymentProcessor);
        c.MakePayment(2000);

    }
}