using System.Collections.Generic;
using TeleMedicineModels.Models.Response;

namespace TeleMedicineDAL.Interfaces
{
	public interface IDoctorRepository
	{
		IList<PatientDetails> GetPatientsDetails();
	}
}
