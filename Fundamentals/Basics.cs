namespace Basics
{
    public class Student
    {
        private int rollNo { get; set; } //fields- to store data

        //methods- to manipulate data  inside  the fields
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
            int x = 1;//local variable
            System.Console.WriteLine(x);//1

            Student Arun = new Student();//object creation
            Arun.setRollNo(150);
            System.Console.WriteLine(Arun.getRollNo());//150
        }
    }
}