using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorySample
{
    class Context
    {
        public List<T> Users { get; set; }

        public Context()
        {
            // populate context

            Users = new List<T>();

            Users.Add(new T
            {
                FirstName = "John",
                LastName = "Smith",
                Age = 29
            });

            Users.Add(new T
            {
                FirstName = "Jake",
                LastName = "Ross",
                Age = 26
            });

            Users.Add(new T
            {
                FirstName = "Jane",
                LastName = "Tarzan",
                Age = 25
            });
        }
    }
}
