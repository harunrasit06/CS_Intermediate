using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSIntermediate.Polymorphism
{
    internal class Exercise
    {
        static void Main1(string[] args)
        {
            var connection = new SqlConnection("sql connection");
            connection.Open();
            
            //connection.TimeOut(5);

            
            //Thread.Sleep(4000);
            connection.Close();

            var connection2 = new OracleConnection("Oracle connection");
            
            connection2.Open();
            //Thread.Sleep(4000);
            connection2.Close();

            var command = new DbCommand(connection2, "Use Datebase");
            command.Execute();

        }
    }
}
