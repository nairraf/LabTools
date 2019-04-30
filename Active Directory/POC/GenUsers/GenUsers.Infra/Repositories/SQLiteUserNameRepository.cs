using GenUsers.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace GenUsers.Infra.Repositories
{
    public class SQLiteUserNameRepository : IUserNameRepository, IDisposable
    {
        private SQLiteConnection _dbConnection;
        
        public SQLiteUserNameRepository(string DbName, string DbPath)
        {
            _dbConnection = new SQLiteConnection($"Data Source={DbPath}{DbName};Version=3;");
            _dbConnection.Open();
        }

        public void Dispose()
        {
            _dbConnection.Close();
        }

        public IEnumerable<string> GetFirstNames()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetLastNames()
        {
            throw new NotImplementedException();
        }
    }
}
