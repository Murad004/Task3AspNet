using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3AspNet.Entities;

namespace Task3AspNet.Services
{
    interface IRepository
    {
        void Add(User item);
        void Delete(int id);
        void Update(int id, User item);
        User Get(int id);
        IEnumerable<User> GetAll();

    }
}
