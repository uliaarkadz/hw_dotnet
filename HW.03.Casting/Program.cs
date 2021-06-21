using System;

namespace HW._03.Casting
{
    class Program
    {
        static void Main(string[] args)
        {
           // Implicit conversion
           Console.WriteLine("*****Implicit conversion*******\n");
            //cast into to long
            int num = 2147483647;
            long bigNum = num;
            Console.WriteLine("Value is: \n" + bigNum);

            // Cast int to double.
            int val1 = 10;
            double val2 = val1;
            Console.WriteLine("Value is: \n" + val2);

            // Cast char to int.
            int number = 1;
            char character = 'k'; /*ASCII value is 107 */
            int sum;
            sum = number + character;
            Console.WriteLine("Value is: \n"  + sum);

            // Cast double to int.
            short x = 1235;
            int a = x;
            Console.WriteLine("Value is: \n"  + a);

            // Cast float to double
            float aFloat = 1.2f;
            double aDouble = aFloat;
            Console.WriteLine("Value is: \n"  + aDouble);
            
            
            //explicit casting
            Console.WriteLine("*****Explicit conversion*******\n");
            // Cast long to int.
            long t = 124574354;
            int d;
            d = (int)t;
            Console.WriteLine("Value of sum : \n" + d);
            
            // Cast double to int.
            double z = 1234.7;
            int y;
            y = (int)z;
            Console.WriteLine("Value is: \n" + z);

            // Conversion from double to int
            double r = 1.2;
            int sum1 = (int)r + 1;
            Console.WriteLine("Value is: \n"  + sum1);
            
            // Cast double to int.
            double num2 = 35.546;
            Console.WriteLine(num2);
            int num3 = Convert.ToInt32(num2); //conversion using convert
            int num4 = (int)num2; // conversion using Cast operator
            Console.WriteLine("Value is: \n"  + num3 + "; " + num4);
            
            // Cast byte to char.
            byte by = 254;
            char character2;
            character2 = (char)by;
            Console.WriteLine("Value is: \n" + character2);

//BOXING
Console.WriteLine("*****BOXING*******\n");

            int i = 10;
            object o = i; 
            Console.WriteLine("Value is: \n" + o);
            
            int h = 10;
            object o1 = i; 
            double dd = (double)(int)o1;
            Console.WriteLine("Value is: \n" + dd);
            
            long ll = 123744323;
            object o2 = ll;
            Console.WriteLine("Value is: \n" + o2);
            
            short ss = 55;
            object o3 = ss;
            Console.WriteLine("Value is: \n" + o3);
            
            char cc = 'A';
            object o4 = cc;
            Console.WriteLine("Value is: \n" + o4);
            
             byte bb = 0;
            object o5 = bb;
            Console.WriteLine("Value is: \n" + o5);


            
            Console.WriteLine("*****UNBOXING******* \n");

            i = (int)o;
            Console.WriteLine("Value is: \n" + i);
            
            h = (int)o1;
            Console.WriteLine("Value is: \n" + h);
            
            ll = (long)o2;
            Console.WriteLine("Value is: \n" + ll);

            ss = (short)o3;
            Console.WriteLine("Value is: \n" + ss);
            
            cc = (char)o4;
            Console.WriteLine("Value is: \n" + cc);
            
            bb = (byte)o5;
            Console.WriteLine("Value is: %d\n" + bb);

        }
    }
}
