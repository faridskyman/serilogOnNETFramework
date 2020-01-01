using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Serilog;
using serilogonNETFramework.Utilities;

namespace serilogonNETFramework.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ErrLogging.WriteLog("index page", Serilog.Events.LogEventLevel.Information);
            Log.Information("Index Page 2");
            try
            {
                for(int i=0;i<10;i++)
                {
                    if (i > 5)
                        throw new Exception("Initiated an Exception");
                }
            }
            catch (Exception ex)
            {
                ErrLogging.WriteLog("Error Caught", Serilog.Events.LogEventLevel.Error, ex);
                Log.Error(ex, "Error Caught - 2");
            }
            finally
            {
                
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ErrLogging.WriteLog("about page", Serilog.Events.LogEventLevel.Information);
            throw new Exception("manual throw exception from ABOUT");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ErrLogging.WriteLog("contact page", Serilog.Events.LogEventLevel.Verbose);
            return View();
        }
    }
}