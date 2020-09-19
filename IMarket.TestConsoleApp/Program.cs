using System;
using System.Linq;
using IMarket.Model;

namespace IMarket.TestConsoleApp
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write("Try insert user..");
            var ctx = new Context();
            ctx.Database.EnsureCreated();

            ctx.Add(new User() {
                Id = Guid.NewGuid(),
                Login = "fffffffff",
                Password = "password"
            });
            Console.Write(ctx.SaveChanges());

            var users = ctx.Users.ToList();
        }
    }
}
