using System;

namespace CSIntermediate.Classes.Exercises
{
    internal partial class Exercises
    {
        public class Post
        {
            private string title;
            private string description;
            private readonly DateTime time;
            //private int upVote;
            //private int downVote;
            private int totalVote;

            public Post(string title, string description)
            {
                this.description = description ?? throw new ArgumentNullException(nameof(description));
                this.title = title ?? throw new ArgumentNullException(nameof(title));
                this.time = DateTime.Now;
                
            }


            public void SetUpVote(int upVote)
            {
                
                this.totalVote += upVote;
            }

            public void SetDownVote(int downVote) 
            {
                
                this.totalVote -= downVote;

            }
            public void DisplayPost() 
            {
                Console.WriteLine(this.title + this.description + this.time.ToString() + " TotalVote: " + this.totalVote.ToString());
      
            }

        }
    }
}
