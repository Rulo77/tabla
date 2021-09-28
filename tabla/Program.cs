using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabla
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1,n2,n3,n4,n5, b, R;


            Console.WriteLine("tabla del 1:");
            n1 = 1;

            for (b = 1; b <= 10; ++b)
            {
                R = n1 * b;
                Console.WriteLine("{0} por {1} = {2}", n1, b, R);

            }

            Console.WriteLine("tabla del 2:");
       
            n2 = 2;

            for (b = 1; b <= 10; ++b)
            {
                R = n2 * b;
                Console.WriteLine("{0} por {1} = {2}", n2, b, R);

            }

            Console.WriteLine("tabla del 3:");
            n3 = 3;

            for (b = 1; b <= 10; ++b)
            {
                R = n3 * b;
                Console.WriteLine("{0} por {1} = {2}", n3, b, R);

            }

            Console.WriteLine("tabla del 4:");
            n4 = 4;

            for (b = 1; b <= 10; ++b)
            {
                R = n4 * b;
                Console.WriteLine("{0} por {1} = {2}", n4, b, R);

            }

            Console.WriteLine("tabla del 5:");
            n5 = 5;

            for (b = 1; b <= 10; ++b)
            {
                R = n5 * b;
                Console.WriteLine("{0} por {1} = {2}", n5, b, R);

            }


            Console.Read();
        }

    }
}
