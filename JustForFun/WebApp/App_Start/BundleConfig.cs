using System.Web;
using System.Web.Optimization;

namespace WebApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/bower_components/ngToast/dist/ngToast.css",
                      "~/bower_components/ngToast/dist/ngToast-animations.css",
                      "~/bower_components/angular-loading-bar/src/loading-bar.css",
                      "~/bower_components/angular-material/angular-material.css"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                    "~/bower_components/angular/angular.js",
                    "~/bower_components/angular-aria/angular-aria.js",
                    "~/bower_components/angular-animate/angular-animate.js",
                    "~/bower_components/angular-sanitize/angular-sanitize.js",
                    "~/bower_components/ngToast/dist/ngToast.js",
                    "~/bower_components/angular-material/angular-material.js",
                    "~/bower_components/angular-loading-bar/src/loading-bar.js",
                    "~/bower_components/angular-ui-router/release/angular-ui-router.js",
                    "~/bower_components/ui-router-extras/release/ct-ui-router-extras.js"                    
                ));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                    "~/Scripts/App/app.js",
                    "~/Scripts/App/Controllers/userController.js"
                ));
        }
    }
}
