using System.Collections.Generic;
using TeleMedicineBLL.Interfaces;
using TeleMedicineDAL.Interfaces;
using TeleMedicineModels.Models.Response;

namespace TeleMedicineBLL.BusinessServices
{
	public class DoctorBS : IDoctorBS
	{
		private readonly IDoctorRepository _doctorRepository;
		public DoctorBS(IDoctorRepository doctorRepository)
		{
			//
			_doctorRepository = doctorRepository;
		}
		public IList<PatientDetails> GetPatientsDetails()
		{
			return _doctorRepository.GetPatientsDetails();
		}
	}
}
