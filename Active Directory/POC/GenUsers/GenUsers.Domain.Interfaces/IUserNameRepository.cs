using GenUsers.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenUsers.Domain.Interfaces
{
    public interface IUserNameRepository
    {
        IEnumerable<string> GetFirstNames();
        IEnumerable<string> GetLastNames();
    }
}
