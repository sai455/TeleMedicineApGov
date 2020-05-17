namespace TeleMedicineModels.Models.Response
{
    public class CallerDetails
    {
        public string CallerType { get; set; }
        public string CallerName { get; set; }
        public string ContactNumber { get; set; }
        public string PastCallRecord { get; set; }
        public string PatientDoctorHistory { get; set; }
        public string CallTime { get; set; }
    }
}
