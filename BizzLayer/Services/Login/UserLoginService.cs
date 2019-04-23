using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;


// 
namespace BizzLayer.Services.LoginService
{
    public class ThereIsNotOnlyOneResult : Exception
    {
        public ThereIsNotOnlyOneResult(string message) : base(message)
        {
        }
    }

    public class AccountExpiredException : Exception
    {
        public AccountExpiredException(string message) : base(message)
        {
        }
    }
    public class UserLoginService
    {
        private static UserLoginService instance = null;

        private UserLoginService()
        {
        }

        public static UserLoginService getInstance()
        {
            if(instance == null)
            {
                UserLoginService.instance = new UserLoginService();
            }
            return UserLoginService.instance;
        }
        public user updateUserData(user userData)
        {
            var db = new DatabaseConnectionContext();
            var result = (from user in db.users
                             where user.uname == userData.uname
                             where user.password == userData.password
                             select user).ToList();

            if ( result.Count != 1 )
            {
                throw new ThereIsNotOnlyOneResult( result.Count.ToString() );
            }

            if ( result.First().expiration_date < DateTime.Today )
            {
                throw new AccountExpiredException( result.First().expiration_date.ToString() );
            }

            return result.First();
        }
    }
}