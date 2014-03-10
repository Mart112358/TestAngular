using System.Web.Optimization;

namespace TestAngular
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular.js",
                "~/Scripts/angular-route.js",
                "~/Scripts/angular-animate.js",
                "~/Scripts/ng-grid-{version}.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/toastr").Include(
                "~/Scripts/toastr.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"
                ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"
                ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/appInit").Include(
                "~/app/app.js",
                "~/app/config.js",
                "~/app/config.route.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/appControllers").Include(
                "~/app/home/home.js",
                "~/app/testNgGrid/testNgGrid.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/appFactories").Include(
                "~/app/factories/logger.js",
                "~/app/factories/customerFactory.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",                
                "~/Content/ng-grid.css",             
                "~/Content/site.css",
                "~/Content/animate.css",
                "~/Content/toastr.css"
                ));
        }
    }
}
