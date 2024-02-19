using System.Text;
using System.Threading.Tasks;

namespace CSIntermediate.InheritanceOOP
{
    internal class Exercise
    {
        static void Main1(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();

        }

    }
}
