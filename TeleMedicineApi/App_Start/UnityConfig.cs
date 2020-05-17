using System.Web.Http;
using TeleMedicineBLL.BusinessServices;
using TeleMedicineBLL.Interfaces;
using TeleMedicineDAL.Interfaces;
using TeleMedicineDAL.Repositories;
using Unity;
using Unity.WebApi;

namespace TeleMedicineApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IAuthenticateBS, AuthenticateBS>();
            container.RegisterType<IReceptionBs, ReceptionBs>();
            container.RegisterType<IDoctorBS, DoctorBS>();

            //Register Data access layer interfaces here..

            container.RegisterType<IAuthenticateRepository, AuthenticateRepository>();
            container.RegisterType<IReceptionRepository, ReceptionRepository>();
            container.RegisterType<IDoctorRepository, DoctorRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}