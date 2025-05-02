
class Sample
{
    public static void Main(string[] args)
    {
        //control statements
        //conditional control statements-if,else,else if,nested if,switch
        //looping control statements-do while,while,for
        //jumping control statements-break,continue
        int age = 18;
        //if statement
        if (age == 18)
        {
            System.Console.WriteLine("your age is 18");
        }

        //if-else
        if (age < 18)
        {
            System.Console.WriteLine("your age is less than 18");
        }
        else
        {
            System.Console.WriteLine("your age is greater than or equal to  18");
        }

        //else if
        if (age < 18)
        {
            System.Console.WriteLine("your age is less than 18");
        }
        else if (age == 18)
        {
            System.Console.WriteLine("Age is exactly 18");
        }
        else
        {
            System.Console.WriteLine("your age is greater than 18");
        }

        //nested if
        if (age >= 18)//outer if
        {
            if (age == 18)//inner if
            {
                System.Console.WriteLine("your age is exactly 18");
            }
            else
            {
                System.Console.WriteLine("your age is greater than 18");
            }
        }
        else
        {
            System.Console.WriteLine("your age is less than 18");
        }

        int weekNum = 6;
        switch (weekNum)//int,char,enum are supported datatypes
        {
            case 0:
                System.Console.WriteLine("Sunday");
                break;
            case 1:
                System.Console.WriteLine("Monday");
                break;
            case 2:
                System.Console.WriteLine("Tuesday");
                break;
            case 3:
                System.Console.WriteLine("Wendnesday");
                break;
            case 4:
                System.Console.WriteLine("Thursday");
                break;
            case 5:
                System.Console.WriteLine("Friday");
                break;
            case 6:
                System.Console.WriteLine("Saturday");
                break;
            default://optional to write
                System.Console.WriteLine("entered value is wrong");
                break;
        }

        //while loop
        System.Console.WriteLine("while loop");
        int num = 1;
        while (num < 5)
        {
            System.Console.WriteLine(num);
            num++;
        }

        System.Console.WriteLine("do while loop");
        //do while //executes ones irrespective of loop condition
        int num2 = 1;
        do
        {
            System.Console.WriteLine(num2);
            num2++;
        } while (num2 < 3);

        //for loop
        System.Console.WriteLine("for loop");
        for (int i = 0; i < 5; i++)//i-block level variable
        {
            System.Console.WriteLine(i);
        }

        //break -stops the loop
        System.Console.WriteLine("break");
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                break;
            }
            System.Console.WriteLine(i);
        }

        //continue-skips the particular iteration
        System.Console.WriteLine("continue");
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                continue;
            }
            System.Console.WriteLine(i);
        }

        //Nested For loop
        System.Console.WriteLine("Nested For loop");
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                System.Console.WriteLine(i + " " + j);
            }
        }

        //goto
        System.Console.WriteLine("goto ");
        int p = 1;
        System.Console.WriteLine("label print");
        labelcode:
        System.Console.WriteLine(p);
        if (p < 3)
        {
            p++;
            goto labelcode;
        }

        GetHeightCategory(75);//Tall
        GetHeightCategory(45); //Dwarf
        FindLargest(10, 56, 7);//56 is greatest
        FindLargest(100, 100, 7);//100 is greatest
        FindLargest(10, 700, 700);//700 is greatest
        patternPrinting();
    }

    public static void GetHeightCategory(int inches)

    {
        double height = inches * 2.54;
        if (height < 150)
        {
            System.Console.WriteLine("Dwarf");
        }
        else if (height <= 165)
        {
            System.Console.WriteLine("Average height");
        }
        else if (height <= 195)
        {
            System.Console.WriteLine("Tall");
        }
        else
        {
            System.Console.WriteLine("Abnormal height");
        }
    }


    public static void FindLargest(int a, int b, int c)
    {
        if (a >= b)
        {
            if (a >= c)
                System.Console.WriteLine(a + " is greatest");
            else
                System.Console.WriteLine(c + " is greatest");
        }
        else
        {
            if (b >= c)
                System.Console.WriteLine(b + " is greatest");
            else
                System.Console.WriteLine(c + "is greatest");
        }

    }

    public static void patternPrinting()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                if (j == 5 || j== 6)
                {
                    continue;

                }
                System.Console.Write(j + " ");
            }
            System.Console.WriteLine();
        }

        for (int i = 0; i < 5; i++)
        {
            if (i < 4)
            {
                for (int j = 10; j > 0; j--)
                {
                    if (i == 2 && (j == 1 || j == 2))
                    {
                        continue;
                    }
                    System.Console.Write(j + " ");
                }
                System.Console.WriteLine();
            }
            else
            {
                for (int k = 1; k <= 10; k++)
                {
                    if (k == 8)
                    {
                        continue;
                    }
                    System.Console.Write(k + " ");
                }

            }
        }
    }
}
