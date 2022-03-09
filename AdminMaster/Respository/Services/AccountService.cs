using AdminMaster.Models;
using AdminMaster.Respository.Interface;
using AdminMaster.Utils.Enums;
using AdminMaster.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminMaster.Respository.Services
{
    public class AccountService : IUsers
    {
        private MSDBContext dbContext;
        public AccountService()
        {
            dbContext = new MSDBContext();
        }
        public SignInEnum SignIn(SignInModel model)
        {
            var user = dbContext.Tb1_Users.SingleOrDefault(e => e
              .Email == model.Email && e.Password == model.Password);
                if (user != null)
                {
                   if (user.Isverified)
                   {
                     if(user.IsActive)
                     {
                        return SignInEnum.Success;
                     }
                    else
                    {
                        return SignInEnum.InActive;
                    }

                   }
                    else
                    {
                        return SignInEnum.NotVerified;
                    }

                }
                else
                {
                  return   SignInEnum.WrongCredentials;
                }
        }

        public SignUpEnum SignUp(SignUp model)
        {
            throw new NotImplementedException();
        }
    }
}
