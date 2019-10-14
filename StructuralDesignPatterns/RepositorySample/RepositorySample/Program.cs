using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorySample
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserRepository userRepo = new UserRepository();

            userRepo.Add(new T
            {
                FirstName = "Jim",
                LastName = "Beam",
                Age = 22
            });

            var users = userRepo.GetAll();

            foreach (var user in users)
            {
                Console.WriteLine(user.FirstName);
            }


            Console.ReadKey(true);
        }
    }
}
