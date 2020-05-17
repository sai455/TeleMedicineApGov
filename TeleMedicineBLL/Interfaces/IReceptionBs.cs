using System.Collections.Generic;
using TeleMedicineModels.Models.Response;

namespace TeleMedicineBLL.Interfaces
{
    public interface IReceptionBs
    {
        IList<CallerDetails> GetCallerDetails();
    }
}
