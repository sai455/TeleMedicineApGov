using System.Collections.Generic;
using TeleMedicineBLL.Interfaces;
using TeleMedicineDAL.Interfaces;
using TeleMedicineModels.Models.Response;

namespace TeleMedicineBLL.BusinessServices
{
    public class ReceptionBs: IReceptionBs
    {
        private readonly IReceptionRepository _reception;
        public ReceptionBs(IReceptionRepository receptionRepository)
        {
            if (_reception == null)
            {
                _reception = receptionRepository;
            }
        }
        public IList<CallerDetails> GetCallerDetails()
        {
            return _reception.GetCallerDetails();
        }
    }
}

