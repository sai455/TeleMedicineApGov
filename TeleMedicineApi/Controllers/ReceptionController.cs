using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeleMedicineBLL.Interfaces;
using TeleMedicineModels.Models.Response;

namespace TeleMedicineApi.Controllers
{
    public class ReceptionController : ApiController
    {
        private readonly IReceptionBs _reception;

        public ReceptionController(IReceptionBs receptionBs)
        {
            if (_reception == null)
            {
                _reception = receptionBs;
            }
        }
        [Route("api/Reception/GetCallerDetails")]
        public IList<CallerDetails> GetCallerDetails()
        {
            return _reception.GetCallerDetails();
        }
    }
}
