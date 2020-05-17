using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using TeleMedicineModels.Models.Response;

namespace TeleMedicineApGov.Controllers
{
	public class DoctorController : Controller
	{
		public string Baseurl = "http://localhost:60543/api/";
		// GET: Doctor
		public ActionResult Index()
		{
			return View();
		}


		[HttpGet]
		public ActionResult GetDiagnosisDetails(int id)
		{
			return View("Diagnosis");
		}

		[HttpGet]
		public ActionResult GetPatientsDetails()
		{
			using (var client = new HttpClient())
			{
				//Passing service base url  
				client.BaseAddress = new Uri(Baseurl);

				client.DefaultRequestHeaders.Clear();
				//Define request data format  
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				//Sending request to find web api REST service resource GetAllEmployees using HttpClient  
				var responseTask = client.GetAsync("Doctor/GetPatientsDetails");
				responseTask.Wait();
				var result = responseTask.Result;
				if (result.IsSuccessStatusCode)
				{
					var response = result.Content.ReadAsStringAsync().Result;
					IList<PatientDetails> callerDetails = (new JavaScriptSerializer()).Deserialize<List<PatientDetails>>(response);
					//Deserializing the response recieved from web api and storing into the Employee list  

					return Json(callerDetails, JsonRequestBehavior.AllowGet);

				}
				else
				{
					return Json("Error", JsonRequestBehavior.AllowGet);
				}
			}

		}
	}
}