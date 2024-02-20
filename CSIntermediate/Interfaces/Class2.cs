using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIntermediate.Interfaces
{
    internal class Class2
    {
        static void Main2(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\temp\\log.txt"));
            dbMigrator.Migrate();

        }
    }
}
