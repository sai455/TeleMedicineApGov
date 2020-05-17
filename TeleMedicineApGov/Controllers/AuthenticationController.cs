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
    public class AuthenticationController : Controller
    {
        public string Baseurl = "http://localhost:60543/api/";
        // GET: Authentication
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetUserByCredientials(string userName, string password)
        {
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                var responseTask = client.GetAsync("Authenticate/GetUserAuthentication/" + userName + "/" + password);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync().Result;
                    AuthenticateResponse authenticate = (new JavaScriptSerializer()).Deserialize<AuthenticateResponse>(result.Content.ReadAsStringAsync().Result);
                    //Deserializing the response recieved from web api and storing into the Employee list  

                    return Json(authenticate, JsonRequestBehavior.AllowGet);

                }
                else
                {
                    return Json("Error", JsonRequestBehavior.AllowGet);
                }
            }

        }
    }
}