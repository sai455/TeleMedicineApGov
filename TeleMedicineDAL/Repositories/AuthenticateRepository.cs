using System;
using System.Linq;
using TeleMedicineDAL.DataContext;
using TeleMedicineDAL.Interfaces;
using TeleMedicineModels.Models.Response;

namespace TeleMedicineDAL.Repositories
{
    public class AuthenticateRepository: IAuthenticateRepository
    {
        public AuthenticateResponse GetUserDetailsByCredientials(string userName, string password)
        {
            AuthenticateResponse response = new AuthenticateResponse();
            using (TeleMedicineEntities entity = new TeleMedicineEntities())
            {
                response = entity.VALIDATEUSER(userName, password).Select(s => new AuthenticateResponse()
                {
                    UserId = s.USER_ID,
                    UserName = s.USER_NAME,
                    RoleId = Convert.ToInt32(s.DESIGNATION_ID),
                    RoleName = s.DESIGNATION_NAME.ToUpper()
                }).FirstOrDefault();
            }
            return response;
        }
    }
}
