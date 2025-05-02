namespace Basics
{
    public class Student
    {
        private int rollNo { get; set; }

        public void setRollNo(int rollNo)
        {
            this.rollNo = rollNo;
        }
        public int getRollNo()
        {
            return this.rollNo;
        }
    }

    public class Sample
    {
        public static void Main(string[] args)
        {
            int x = 10;//local variable
            System.Console.WriteLine(x);//10

            Student Arun = new Student();//object creation
            Arun.setRollNo(15);
            System.Console.WriteLine(Arun.getRollNo());//15
        }
    }
}