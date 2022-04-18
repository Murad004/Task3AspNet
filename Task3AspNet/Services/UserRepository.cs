using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3AspNet.DATA;
using Task3AspNet.Entities;

namespace Task3AspNet.Services
{
    public class UserRepository : IRepository
    {

        private readonly UserDbContext _context;

        public UserRepository(UserDbContext context)
        {
            _context = context;
        }

        public void Add(User item)
        {
            _context.users.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = _context.users.Where(x => x.Id == id).ToArray();
            if (user != null)
            {
                _context.users.Remove(user[0]);
                _context.SaveChanges();
            }
        }

        public User Get(int id)
        {
            var user = _context.users.Where(x => x.Id == id).ToArray();
            return user[0];
        }

        public IEnumerable<User> GetAll()
        {
            return _context.users.ToList();
        }

        public void Update(int id, User item)
        {
            var user = Get(id);
            user.Name = item.Name;
            user.Surname = item.Surname;
            user.Age = item.Age;
            user.Salary = item.Salary;
            user.Address = item.Address;
            _context.SaveChanges();
        }
    }
}
