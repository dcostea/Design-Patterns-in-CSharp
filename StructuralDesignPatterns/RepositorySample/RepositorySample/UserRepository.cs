using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorySample
{
    class UserRepository : IUserRepository
    {
        Context userContext;

        public UserRepository()
        {
            userContext = new Context();
        }

        public IEnumerable<T> GetAll()
        {
            return userContext.Users;
        }

        public T GetByName(string name)
        {
            return userContext.Users.Find(u => u.FirstName == name || u.LastName == name);
        }

        public T GetById(int id)
        {
            //return userContext.Users.Find(id); // ignored for this sample
            return userContext.Users.First(); // simplified for this sample
        }

        public void Add(T user)
        {
            userContext.Users.Add(user);
            //userContext.SaveChanges(); // ignored for this sample
        }


        public void Delete(T user)
        {
            userContext.Users.Remove(user);
            //userContext.SaveChanges(); // ignored for this sample
        }

        public void Update(T user)
        {
            //userContext.Entry(user).State = EntityState.Modified; // ignored for this sample
            //userContext.SaveChanges(); // ignored for this sample
        }

    }
}
