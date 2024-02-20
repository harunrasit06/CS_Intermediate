using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIntermediate.Interfaces.exercise
{
    public interface IActivity
    {
        void Execute();
    }

    public class WorkflowEngine
    {
        private readonly List<IActivity> _workflow;
        public WorkflowEngine(List<IActivity> workflow)
        {
            _workflow = workflow;
        }
        public void Run()
        {
            foreach (IActivity activity in _workflow)
            {
                activity.Execute();
            }
        }
    }

    public class Upload : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("Uploading video to the cloud storage...");
        }
    }
    public class Call : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("Calling the web service provided by a third-party video encoding service to tell them thez have a video ready for encoding...");
        }
    }
    public class SendEmail : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("Sending email to the owner of the video notifying them that the video started processing... ");
        }
    }

    public class ProcessingStatus : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("Changing the status of the video record in the database to Processing...");
        }
    }
    class Exercise
    {
        static void Main(string[] args)
        {
            var workflow = new List<IActivity> { new Upload(), new Call(), new SendEmail(), new ProcessingStatus() };

            var workflowEngine = new WorkflowEngine(workflow);

            workflowEngine.Run();
        }
    }
    }
