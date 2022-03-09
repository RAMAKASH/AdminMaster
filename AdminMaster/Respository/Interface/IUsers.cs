using AdminMaster.Utils.Enums;
using AdminMaster.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminMaster.Respository.Interface
{
    public interface IUsers
    {
       SignInEnum  SignIn(SignInModel model);
        SignUpEnum SignUp(SignUp model);
    }
}
