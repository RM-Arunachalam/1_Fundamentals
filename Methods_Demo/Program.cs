class Car
{
    public double carPrice { get; set; }
    public string carBrand { get; set; }

    public double CalculateEMI(int price,int year,int interestRate)
    {
        return (price *year*interestRate)/100;
    }
}
class Sample
{
    public static void Main(string[] args)
    {
        Car benz=new Car();
        double emi=benz.CalculateEMI(1000, 2,5);
        Console.WriteLine(emi);//100
    }
}

