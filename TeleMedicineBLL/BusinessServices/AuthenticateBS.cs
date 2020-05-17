using TeleMedicineBLL.Interfaces;
using TeleMedicineDAL.Interfaces;
using TeleMedicineModels.Models.Response;

namespace TeleMedicineBLL.BusinessServices
{
    public class AuthenticateBS: IAuthenticateBS
    {
        private readonly IAuthenticateRepository _authenticate;
        public AuthenticateBS(IAuthenticateRepository authenticateRepository)
        {
            if (_authenticate == null)
            {
                _authenticate = authenticateRepository;
            }
        }
        public AuthenticateResponse GetUserDetailsByCredientials(string userName, string password)
        {
            return _authenticate.GetUserDetailsByCredientials(userName, password);
        }
    }
}
