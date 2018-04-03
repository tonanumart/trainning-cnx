using LibTrainning.CodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new TodoDataContext())
            {
                var usr = new User();
                //usr.PasswordHash = "Connex123";
                usr.SetPassword("Connex123");
                context.Users.Add(usr);
                context.SaveChanges();     
            }

        }
    }
}
