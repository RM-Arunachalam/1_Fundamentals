namespace ConsoleClassDemo
{
    class Sample
    {
        public static void Main(string[] args)
        {
            System.Console.Write("hello ");//console class[static class]-all members are accessible without creating object
            System.Console.WriteLine();//printing empty line
            System.Console.WriteLine("Enter a number");
            string number = System.Console.ReadLine();
            System.Console.WriteLine("Entered number is " + number);
            System.Console.ReadKey();//waits for user to press some key
            System.Console.Clear();

            int number_stored = 10;//local variable-short lives
            System.Console.WriteLine(number_stored);
            string name = "Arun"; //string literal-collection of unicode characters[empty/null]
            System.Console.WriteLine("Name stored is " + name);

            System.Console.WriteLine("printing const fields");
            System.Console.WriteLine("sbyte.MinValue->" + sbyte.MinValue);
            System.Console.WriteLine("sbyte.MaxValue->" + sbyte.MaxValue);
            System.Console.WriteLine("byte.MinValue->" + byte.MinValue);
            System.Console.WriteLine("byte.MaxValue->" + byte.MaxValue);
            System.Console.WriteLine("short.MinValue->" + short.MinValue);
            System.Console.WriteLine("short.MaxValue->" + short.MaxValue);
            System.Console.WriteLine("ushort.MinValue->" + ushort.MinValue);
            System.Console.WriteLine("ushort.MaxValue->" + ushort.MaxValue);
            System.Console.WriteLine("int.MinValue->" + int.MinValue);//default integral literal value is of int datatype
            System.Console.WriteLine("int.MaxValue->" + int.MaxValue);
            System.Console.WriteLine("uint.MinValue->" + uint.MinValue);
            System.Console.WriteLine("uint.MaxValue->" + uint.MaxValue);
            System.Console.WriteLine("long.MinValue->" + long.MinValue);
            System.Console.WriteLine("long.MaxValue->" + long.MaxValue);
            System.Console.WriteLine("ulong.MinValue->" + ulong.MinValue);
            System.Console.WriteLine("ulong.MaxValue->" + ulong.MaxValue);

            System.Console.WriteLine("float.MinValue->" + float.MinValue);
            System.Console.WriteLine("float.MaxValue->" + float.MaxValue);
            System.Console.WriteLine("double.MinValue->" + double.MinValue);
            System.Console.WriteLine("double.MaxValue->" + double.MaxValue);
            System.Console.WriteLine("decimal.MinValue->" + decimal.MinValue);
            System.Console.WriteLine("decimal.MaxValue->" + decimal.MaxValue);

            float floatVal = 3.14f;
            double doubleVal = 67.89;//by default,floating point literal are of double datatype
            decimal decimalVal = 342.76M;
            System.Console.WriteLine(floatVal + " " + doubleVal + " " + decimalVal);

            char charValue = 'a';
            System.Console.WriteLine(charValue);
            System.Console.WriteLine("default char value is=>"+default(char));//default ->\0(null)

            bool switchvalue = false;//1 bit (default-false)
            System.Console.WriteLine(switchvalue);

            //to find default value
            System.Console.WriteLine(default(string));//null
            //null- no memory allocated, empty- empty string, blank(can be spaces)

            byte b = 32;//here 32 is treated as integer(default integral datatype)
            System.Console.WriteLine(b);

            //operators
            int x = 10;
            int y = 3;//assignment operator(=)
            System.Console.WriteLine(10 % 3);//Arithmetic ->+,-,*,/,%    //1
            System.Console.WriteLine(y += 3);//assignment operator(+=,-=,/=,*=,%=,=) //6
            System.Console.WriteLine(++x);//pre/post inc/dec //11
            System.Console.WriteLine(x++);//pre/post inc/dec //11
            System.Console.WriteLine(x);//12
            System.Console.WriteLine(56 > 87);//comparison operator(returns boolean only)  >,>=,<.<=,==   //false
            System.Console.WriteLine(8 > 7 & 18 < 6);//logical operator(&,|) -checks both //false
            System.Console.WriteLine(8 > 7 || 18 > 6);//conditional operator(&&,||) -checks smartly,not always both //true
            System.Console.WriteLine(5 > 7 ^ 8 > 1);//XOR -any 1 needs to be true to return true //true
            System.Console.WriteLine(!(5 > 7));//negation operator //true
            System.Console.WriteLine("Number" + 234);//Number234  //concatenation operator
            System.Console.WriteLine("Number" + "String");//NumberString
            System.Console.WriteLine(10 > 6 ? "10 is greater than 6" : "10 is not greater than 6");//ternary conditional operator//10 is greater than 6
            int age = 18;
            System.Console.WriteLine(age < 13 ? "child" : (age > 13 && age < 18 ? "teenager" : "adult"));

            System.Console.WriteLine("Area of circle->" + AreaOfCircle(2));//12.56636
            System.Console.WriteLine("FeetInches to Cm" + FeetToCentimetres(5, 7));//170.18cm  
            NearestThsnd(999);
            NearestThsnd(1000);
            NearestThsnd(1499);
            NearestThsnd(1500);
        }
        /// <summary>
        /// Area of circle
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double AreaOfCircle(int radius)
        {
            //const double PI = 3.14159;
            return Math.PI * radius * radius;
        }

        /// <summary>
        /// FeetToCentimetres
        /// </summary>
        /// <param name="feet"></param>
        /// <param name="inches"></param>
        /// <returns></returns>
        public static double FeetToCentimetres(int feet, int inches)
        {
            return ((feet * 12) + inches) * 2.54;
        }


        public static  void NearestThsnd(int number)
        {
            //If the number's last three digits are greater than or equal to 500; it should "round up" the number.
            //If the number's last three digits are less than 500; it should "round down" the number.
            //If the number is less than 500; it should round up to 1000.
            decimal decimalNumber = number;

            int previousThousand = number / 1000 * 1000;//3000

            decimal x = decimalNumber / 1000; // 3.852
            decimal y = number / 1000;        // 3

            decimal lastThreeDigits = (x - y) * 1000; // 852

            int roundingValue = (lastThreeDigits >= 500) ? 1000 : 0;
            int roundIfSmall = (number < 500) ? 1000 : 0;

            int nearestThousand = previousThousand + roundingValue + roundIfSmall;//3000 + 1000 + 0 = 4000

            Console.WriteLine(nearestThousand); // Output: 4000
            Console.ReadKey();

        }

    }
}