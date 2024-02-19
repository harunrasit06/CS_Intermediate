using System;

namespace CSIntermediate.Polymorphism
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connection) : base(connection)
        {
        }

        public override void Open()
        {
            Console.WriteLine("Connection to Oracle-Database established!");
            
        }
        public override void Close()
        {
            Console.WriteLine("Oracle-Database is closed!");
        }

    }
}
