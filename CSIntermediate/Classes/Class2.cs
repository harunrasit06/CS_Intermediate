using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIntermediate
{
    internal partial class Class2
    {
        static void Main2(string[] args)
        {
            try {
                int num = int.Parse("abc");

            } 
            catch (Exception e) {
                Console.WriteLine("Conversion faild!");
            }
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion faild!");
            }
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1,2));
            Console.WriteLine(calculator.Add(1, 2,3));
            Console.WriteLine(calculator.Add(1, 2,3,4));
            Console.WriteLine(calculator.Add(new int[] {1,2,3,4,5}));

        }

        static void UsePoints()
        {
            try
            {

                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at ({0}, {1})", point.x, point.y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.x, point.y);
            }
            catch (Exception)
            {

                Console.WriteLine("An unexpented error occured"); ;
            }

        }
    }
}
