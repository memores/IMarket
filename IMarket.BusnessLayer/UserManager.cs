using System;
using IMarket.Model;
using IMarket.Model.ModelFirst;

namespace IMarket.BusnessLayer
{
    public class UserManager
    {
        public bool AddUser(string login, string password) {
            var user = new User() {
                Id = Guid.NewGuid(),
                Login = login,
                Password = password
            };

            var context = new Context();
            context.Users.Add(user);

            if (context.SaveChanges() != 1)
                return false;
            
            return true;



        }


    }
}
