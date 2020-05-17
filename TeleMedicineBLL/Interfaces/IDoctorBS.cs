using System.Collections.Generic;
using TeleMedicineModels.Models.Response;

namespace TeleMedicineBLL.Interfaces
{
	public interface IDoctorBS
	{
		IList<PatientDetails> GetPatientsDetails();
	}
}
