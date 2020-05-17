using System.Collections.Generic;
using System.Linq;
using TeleMedicineDAL.Interfaces;
using TeleMedicineModels.Models.Response;
using TeleMedicineDAL.DataContext;

namespace TeleMedicineDAL.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        public IList<PatientDetails> GetPatientsDetails()
        {
            IList<PatientDetails> patientDetailsList;
            using (TeleMedicineEntities entity = new TeleMedicineEntities())
            {
                patientDetailsList = new List<PatientDetails>();
                patientDetailsList = entity.GETPATIENT_BASIC_DETAILS().Select(p => new PatientDetails()
                {
                    Age = p.AGE ?? default,
                    Date = p.CREATED_DATE.HasValue ? p.CREATED_DATE.Value.ToString("dd/MM/yyyy") : string.Empty,
                    Gender = p.GENDER,
                    Name = p.NAME,
                    PatientId = p.PatientId ?? default,
                    SentBy = p.SentBy,
                    Status = p.STATUS.HasValue ? (p.STATUS == 1 ? "EMERGENCY" : "NON-EMERGENCY") : string.Empty,
                    TokenNo = p.TokenNo ?? default,
                    Visit = p.Visit
                    
                }).ToList();
            }
            return patientDetailsList;
        }
    }
}
