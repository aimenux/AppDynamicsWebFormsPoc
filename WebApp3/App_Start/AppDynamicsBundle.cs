using System;
using System.Configuration;
using System.Web.Optimization;

namespace WebApp3
{
    public class AppDynamicsBundle
    {
        public Bundle Bundle { get; }

        public AppDynamicsBundle()
        {
            Bundle = new ScriptBundle("~/bundles/appdynamics")
                .Include("~/Scripts/AppDynamics/appdynamics.js", new AppDynamicsTransform())
                .Include("~/Scripts/AppDynamics/adrum-20.9.0.3268.js");
        }

        public static bool IsAppDynamicsEnabled()
        {
            return Convert.ToBoolean(ConfigurationManager.AppSettings["EnableAppDynamics"]);
        }

        public class AppDynamicsTransform : IItemTransform
        {
            public string Process(string includedVirtualPath, string input)
            {
                var key = ConfigurationManager.AppSettings["AppDynamicsKey"];
                var result = input.Replace("config.appKey = \"\";", $"config.appKey = \"{key}\";");
                return result;
            }
        }
    }
}