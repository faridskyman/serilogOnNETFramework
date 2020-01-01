using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Serilog;
using Serilog.Sinks;
using Serilog.Formatting.Compact;
using Microsoft.Extensions.Configuration;

namespace serilogonNETFramework
{
    public class MvcApplication : System.Web.HttpApplication
    {
        //public ILogger sLog { get; set; }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
             .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();

            //var sLog = new LoggerConfiguration()
            //    //.MinimumLevel.Error()
            //    .MinimumLevel.Information()
            //    .Enrich.WithMvcActionName()
            //    .Enrich.WithMvcControllerName()
            //    .Enrich.WithMvcRouteData()
            //    .Enrich.WithMvcRouteTemplate()
            //    .Enrich.WithHttpRequestUrl()
            //    .Enrich.WithHttpRequestUserAgent()
            //    .Enrich.WithHttpRequestRawUrl()
            //    .WriteTo.File(new CompactJsonFormatter(), HostingEnvironment.MapPath("~/ErrorLog/sLog2.txt"))
            //    .WriteTo.File(HostingEnvironment.MapPath("~/ErrorLog/sLog.txt"), rollingInterval: RollingInterval.Day,
            //    fileSizeLimitBytes: 5242880,
            //    rollOnFileSizeLimit: true)
            //    .WriteTo.Seq("http://localhost:8081", Serilog.Events.LogEventLevel.Information)
            //    .CreateLogger();

            //Log.Logger = sLog;
        }

        protected void Application_Error()
        {
            var ex = Server.GetLastError();
            Log.Error(ex, "Error from App Error()");

        }
    }
}
