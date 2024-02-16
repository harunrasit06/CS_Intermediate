using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIntermediate.Classes.Exercises
{
    /*Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should
provide two methods: Start and Stop. We call the start method first, and the stop method next.
Then we ask the stopwatch about the duration between start and stop. Duration should be a
value in TimeSpan. Display the duration on the console.
We should also be able to use a stopwatch multiple times. So we may start and stop it and then
start and stop it again. Make sure the duration value each time is calculated properly.
We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
start time). So the class should throw an InvalidOperationException if its started twice.
"1
Educational tip: The aim of this exercise is to make you understand that a class should be
always in a valid state. We use encapsulation and information hiding to achieve that. The class
should not reveal its implementation detail. It only reveals a little bit, like a blackbox. From the
outside, you should not be able to misuse a class because you shouldn’t be able to see the
implementation detail.*/
    internal partial class Exercises
    {
        static void Main1(string[] args)
        {
            // for exercise 1
            //var stopWatch = new Stopwatch();

            //stopWatch.Start();

            // for exercise 2
            var post1 = new Post("First Code ", "Hallo World! Coding..");

            post1.SetUpVote(1);
            //post1.DisplayPost();

            var post2 = new Post("Second Post", "Second Post");

            post2.SetUpVote(2);
            //post2.DisplayPost();

            post1.SetDownVote(2);
            post1.SetUpVote(5);
            post2.SetUpVote(2);
            post2.SetDownVote(9);

            post1.DisplayPost();
            post2.DisplayPost();    
            
        
        }
    }
}
