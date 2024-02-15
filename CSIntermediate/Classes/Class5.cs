using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIntermediate.Classes
{

    internal class Class5
    {
        static void Main5(string[] args)
        {
            var person = new Person(new System.DateTime(1982, 1, 1));
            //person.Birthdate = new System.DateTime(1982, 1, 1);
            Console.WriteLine(person.Age);

        }
    }
}
