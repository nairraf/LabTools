using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using GenUsers.Domain.Interfaces;
using GenUsers.Infra.Repositories;

namespace GenUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var DbName = Properties.Settings.Default.SQLiteDbName;
            var DbPath = Properties.Settings.Default.SQLiteDbPath;

            IUserNameRepository repo = new SQLiteUserNameRepository(DbName, DbPath);

            Console.ReadLine();
        }
    }
}
