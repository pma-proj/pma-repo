using PMAInfrastructure.DataAccess;
using PMAInfrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMAInfrastructure.Repository
{
    public class AuthenticationRepository
    {
        AuthenticationDataDataContext _authenticationDb;

        public MemberModel Authenticate(string login)
        {
            _authenticationDb = new AuthenticationDataDataContext();

            return _authenticationDb.fcn_Authenticate(login).Select(m => new MemberModel { 
                Id = m.Id,
                LastName = m.LastName,
                FirstName = m.FirstName,
                Address = m.Address,
                PostalCode = m.PostalCode,
                City = m.City,
                BirthDate = m.BirthDate,
                Telephone = m.Telephone,
                Mail = m.Mail,
                Password = m.Password
            }).SingleOrDefault();
        }
    }
}
