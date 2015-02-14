using System.Web.Optimization;
using System.Web.Optimization.React;

namespace Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // set react version based on the Environment
            var react = MvcApplication.Environment == MvcApplication.AppEnvironment.Development
                ? "~/Scripts/react/react-with-addons-{version}.js"
                : "~/Scripts/react/react-{version}.js";
            bundles.Add(new ScriptBundle("~/bundles/react").Include(react));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new JsxBundle("~/bundles/comments")
                   .Include("~/Scripts/jquery.signalR-{version}.js")
                   .IncludeDirectory("~/Scripts/Core", "*.jsx")
                   .IncludeDirectory("~/Scripts/Comments", "*.jsx"));

            // Forces files to be combined and minified in debug mode
            // Only used here to test that combination/minification works
            // Normally you would use unminified versions in debug mode.
            //BundleTable.EnableOptimizations = true;
        }
    }
}
