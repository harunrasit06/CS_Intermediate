using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIntermediate.Classes
{
    public class PersonAlt
    {
        private DateTime _birtdate;

        public void SetBirthdate(DateTime birtdate)
        {
            _birtdate = birtdate;
        }
        public DateTime GetDateTime()
        {
            return _birtdate;
        }
    }
    internal class Class4
    {
        static void Main4(string[] args)
        {
            var person = new PersonAlt();
            person.SetBirthdate(DateTime.Now);
            Console.WriteLine(person.GetDateTime());
        }

    }
}
