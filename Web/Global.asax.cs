using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Web
{
    public class MvcApplication : System.Web.HttpApplication
    {

        /// <summary>
        /// Application environment enum
        /// </summary>
        public enum AppEnvironment
        {
            /// <summary>
            /// Development Environment
            /// </summary>
            Development,
            /// <summary>
            /// Production Environment
            /// </summary>
            Production
        }

        /// <summary>
        /// Application.Environment automatically switches from Development to Production,
        /// if the build type is debug or release. Enum also supports Test (aka QA)
        /// </summary>
        public static AppEnvironment Environment
        {
            get
            {
#if DEBUG
                return AppEnvironment.Development;
#else
                return AppEnvironment.Production;
#endif
            }
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
