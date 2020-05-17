using System.Collections.Generic;
using TeleMedicineModels.Models.Response;

namespace TeleMedicineDAL.Interfaces
{
    public interface IReceptionRepository
    {
        IList<CallerDetails> GetCallerDetails();
    }
}
