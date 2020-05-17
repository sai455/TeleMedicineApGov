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
    public class ReceptionController : Controller
    {
        public string Baseurl = "http://localhost:60543/api/";
        // GET: Reception
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetCallerDetails()
        {
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                var responseTask = client.GetAsync("Reception/GetCallerDetails");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync().Result;
                    IList<CallerDetails> callerDetails = (new JavaScriptSerializer()).Deserialize<List<CallerDetails>>(response);
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