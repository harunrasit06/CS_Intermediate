using System;

namespace CSIntermediate.Polymorphism
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connection) : base(connection)
        {
        }

        public override void Open()
        {
            Console.WriteLine("Connection to SQL-Database established!");
            
        }
        public override void Close()
        {
            Console.WriteLine("SQL-Database is closed!");

        }
    }
}
