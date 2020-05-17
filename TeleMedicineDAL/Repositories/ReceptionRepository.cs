using System;
using System.Collections.Generic;
using System.Linq;
using TeleMedicineDAL.DataContext;
using TeleMedicineDAL.Interfaces;
using TeleMedicineModels.Models.Response;

namespace TeleMedicineDAL.Repositories
{
    public class ReceptionRepository: IReceptionRepository
    {
        public IList<CallerDetails> GetCallerDetails()
        {
            IList<CallerDetails> callerDetailsList = new List<CallerDetails>();
            using (TeleMedicineEntities entity = new TeleMedicineEntities())
            {
                callerDetailsList = entity.GETCALLERDETAILS().Select(s => new CallerDetails()
                {
                    CallerType=s.CallerTyoe,
                    CallerName=s.callername,
                    ContactNumber=s.contactnumber,
                    PastCallRecord=s.pastcallrecord,
                    PatientDoctorHistory=s.patientdoctorhistory,
                    CallTime=s.calltime
                }).ToList();
            }
            return callerDetailsList;
        }
    }
}
