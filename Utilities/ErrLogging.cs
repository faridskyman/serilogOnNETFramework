
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using Serilog;
using Serilog.Events;
using Serilog.Formatting.Compact;


namespace serilogonNETFramework.Utilities
{
    public static class ErrLogging
    {
        public static ILogger ErrorLog{ get; set; }

        static ErrLogging()
        {
            //ErrorLog = new LoggerConfiguration()
            //    //.MinimumLevel.Error()
            //    .MinimumLevel.Information()
            //    .Enrich.WithMvcActionName()
            //    .Enrich.WithMvcControllerName()
            //    .Enrich.WithMvcRouteData()
            //    .Enrich.WithMvcRouteTemplate()

            //    .Enrich.WithHttpRequestUrl()
            //    .Enrich.WithHttpRequestUserAgent()
            //    .Enrich.WithHttpRequestRawUrl()
            //    .WriteTo.File(new CompactJsonFormatter(), HostingEnvironment.MapPath("~/ErrorLog/Log2.txt"))
            //    .WriteTo.File(HostingEnvironment.MapPath("~/ErrorLog/Log.txt"), rollingInterval: RollingInterval.Day,
            //    fileSizeLimitBytes: 5242880,
            //    rollOnFileSizeLimit: true)



            //    .CreateLogger();
        }

        //public static void WriteError(Exception ex, string message)
        //{
        //    ErrorLog.Error(ex, message);
        //    ErrorLog.Write(LogEventLevel.Error, ex, message);
        //}

        public static void WriteLog(string message, LogEventLevel lvl, Exception ex = null)
        {
            //ErrorLog.Write(lvl, ex, message);
        }

        //public static void JustLog(int type, string msg, Exception ex=null)
        //{
        //    switch(type)
        //    {
        //        case 1:
        //            ErrorLog.Information(msg);
        //            break;
        //        case 2:
        //            ErrorLog.Verbose(msg);
        //            break;
        //        case 3:
        //            ErrorLog.Warning(msg);
        //            break;
        //        case 4:
        //            ErrorLog.Error(ex, msg);
        //            break;
        //        default:
        //            ErrorLog.Information(msg);
        //            break;
        //    }
        //}
    }
}