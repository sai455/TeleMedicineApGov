using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeleMedicineApi.Models;
using TeleMedicineBLL.Interfaces;
using TeleMedicineModels.Models.Response;

namespace TeleMedicineApi.Controllers
{
    public class AuthenticateController : ApiController
    {
        private readonly IAuthenticateBS _authenticate;

        public AuthenticateController(IAuthenticateBS authenticateBS)
        {
            if (_authenticate == null)
            {
                 
                _authenticate = authenticateBS;
            }
        }

        [Route("api/Authenticate/GetUserAuthentication/{userName}/{password}")]
        public HttpResponseMessage GetUserAuthentication(string userName, string password)
        {
            AuthenticateResponse authenticate = _authenticate.GetUserDetailsByCredientials(userName, password);
            UserIdentity userIdentity = null;
            if (authenticate != null)
            {
                var token = Token.Instance.Generate(userName);
                var response = Request.CreateResponse(HttpStatusCode.OK, userIdentity = new UserIdentity
                {
                    UserName = authenticate.UserName,
                    RoleName = authenticate.RoleName
                });

                // var response = Request.CreateResponse(HttpStatusCode.OK, objResponse);
                response.Headers.Add("Token", token.TokenId.ToString());

                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.Unauthorized, Constants.Unauthorized);
            }
        }
    }
}
