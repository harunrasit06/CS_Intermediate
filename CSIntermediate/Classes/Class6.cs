using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIntermediate.Classes
{
    internal class Class6
    {
        static void Main6(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Test";
            Console.WriteLine(cookie["name"]);
                       


        }
    }
}
