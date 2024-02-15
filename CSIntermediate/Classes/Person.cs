using System;

namespace CSIntermediate.Classes
{
    public class Person
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthdate { get; private set; }
        
        public Person(DateTime birtdate) {
            Birthdate = birtdate;
        }
        public int Age {
            get{ var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;

            }
        
        }
    }
}
