using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIntermediate
{
    internal class Class3
    {
        static void Main3(string[] args)
        {
            var customer = new Customer();
            customer.Orders.Add(new Order { });
            customer.Orders.Add(new Order { });

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);
        }
    }
}
