using PMABusiness.DTO;
using PMAInfrastructure.Model;
using PMAInfrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMABusiness
{
    public class AuthenticationTasks
    {
        AuthenticationRepository authenticationDb;

        public AuthenticationTasks()
        {
            authenticationDb = new AuthenticationRepository();
        }

        public MemberDataReturn Authenticate(string login)
        {
            return new MemberDataReturn { Model = new AuthenticationRepository().Authenticate(login) };
        }
    }
}
