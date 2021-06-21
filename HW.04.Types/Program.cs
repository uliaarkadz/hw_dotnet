using System;

namespace HW._04.Types
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sb1 = 0;
            SByte sb2 = 0;
            Console.WriteLine(sb1.GetTypeCode());
            Console.WriteLine(sb2.GetTypeCode());

            short s1 = 32000;
            Int16 s2 = 32000;
            Console.WriteLine(s2.GetTypeCode());
            Console.WriteLine(s2.GetTypeCode());

            long l1 = 9223372036854775807;
            Int64 l2 = 9223372036854775807;
            Console.WriteLine(l1.GetTypeCode());
            Console.WriteLine(l2.GetTypeCode());

            int i1 = 12;
            Int32 i2 = 12;
            Console.WriteLine(i1.GetTypeCode());
            Console.WriteLine(i2.GetTypeCode());

            byte b1 = 2;
            Byte b2 = 255;
            Console.WriteLine(b1.GetTypeCode());
            Console.WriteLine(b2.GetTypeCode());

            ushort us1 = 65000;
            UInt16 us2 = 65000;
            Console.WriteLine(us1.GetTypeCode());
            Console.WriteLine(us2.GetTypeCode());

            char c1 = 'A';
            Char c2 = 'F';
            Console.WriteLine(c1.GetTypeCode());
            Console.WriteLine(c2.GetTypeCode());

            uint ui1 = 457878564;
            UInt32 ui2 = 83764293;
            
            Console.WriteLine(ui1.GetTypeCode());
            Console.WriteLine(ui2.GetTypeCode());

            ulong ul1 = 9000000000;
            UInt64 ul2 = 9000000000;
            Console.WriteLine(ul1.GetTypeCode());
            Console.WriteLine(ul2.GetTypeCode());
            
            float f1 = 1.4f;
            Single f2 = 1.4f;
            Console.WriteLine(f1.GetTypeCode());
            Console.WriteLine(f2.GetTypeCode());

            double d1 = 12.866969;
            Double d2 = 12.866969;
            Console.WriteLine(d1.GetTypeCode());
            Console.WriteLine(d2.GetTypeCode());

            decimal dd1 = 7845.757490654656564m;
            Decimal dd2 = 7845.757490654656564m;
            Console.WriteLine(dd1.GetTypeCode());
            Console.WriteLine(dd2.GetTypeCode());

        }
    }
}