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
    public class DoctorController : ApiController
    {
        private readonly IDoctorBS _doctorBS;
        public DoctorController(IDoctorBS doctorBS)
        {
            _doctorBS = doctorBS;
        }

        [Route("api/Doctor/GetPatientsDetails")]
        public IList<PatientDetails> GetPatientsDetails()
        {
            return _doctorBS.GetPatientsDetails();
        }

    }
}
