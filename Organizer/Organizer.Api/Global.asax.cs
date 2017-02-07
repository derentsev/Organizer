using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Organizer.Service;
using Organizer.DAL;
using static Organizer.Api.App_Start.AutoMapperConfig;
using Utils;

namespace Organizer.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            RegisterMapping();
            

            //Mapper.Initialize(cfg => cfg.CreateMap(typeof(Source<>), typeof(Destination<>)));
            /*Mapper.Initialize(cfg =>
                                    cfg.CreateMap(typeof(Source<>), typeof(Destination<>)).ConvertUsing(typeof(Converter<,>))); */
        }
    }
}
