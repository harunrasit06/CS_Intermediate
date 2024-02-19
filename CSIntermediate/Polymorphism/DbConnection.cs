using System;
using System.Net;

namespace CSIntermediate.Polymorphism
{
    public class DbCommand 
    {
        public string CommandText { get; set; }
        public DbConnection DbConnection { get; set; }
        public DbCommand(DbConnection dbConnection, string CommandText)
        {
            if (String.IsNullOrEmpty(CommandText)) throw new ArgumentNullException(CommandText);
            this.DbConnection = dbConnection;
            this.CommandText = CommandText;
            
        }

        public void Execute()
        {
            DbConnection.Open();
            Console.WriteLine("Command beig executed {0}", CommandText);
            DbConnection.Close();
        }
    }
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout = TimeSpan.FromSeconds(3); 

        public DbConnection(string connection)
        {
            if (String.IsNullOrEmpty(connection)) throw new ArgumentNullException(nameof(connection));
            this.ConnectionString = connection;
            
        }

        public void TimeOut(int seconds)
        {

            if (Timeout.TotalSeconds < seconds) { throw new Exception(ConnectionString); }

        }

        public abstract void Open();
        public abstract void Close();
    }
}
