using TeleMedicineModels.Models.Response;

namespace TeleMedicineDAL.Interfaces
{
    public interface IAuthenticateRepository
    {
        AuthenticateResponse GetUserDetailsByCredientials(string userName, string password);
    }
}
