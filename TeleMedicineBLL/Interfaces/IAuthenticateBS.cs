using TeleMedicineModels.Models.Response;

namespace TeleMedicineBLL.Interfaces
{
    public interface IAuthenticateBS
    {
        AuthenticateResponse GetUserDetailsByCredientials(string userName, string password);
    }
}
