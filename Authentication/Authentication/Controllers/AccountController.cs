using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Controllers
{
    public class AccountController
    {

        public void Login()
        {
            Console.WriteLine("Add email :");
            string email = Console.ReadLine();

            Console.WriteLine("Add password");
            string Password = Console.ReadLine();

            int RoleId = 1;

            IAccountService account = new AccountService();

            string result = account.Login(email,Password, RoleId);
            Console.WriteLine(result);
        }


    }
}
