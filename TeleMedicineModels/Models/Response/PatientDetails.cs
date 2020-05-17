using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeleMedicineModels.Models.Response
{
	public class PatientDetails
	{
        public int TokenNo { get; set; }
		public int PatientId { get; set; }
		public int Visit { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public string Gender { get; set; }
		public string Date { get; set; }
		public string SentBy { get; set; }
		public string Status { get; set; }
	}
}
