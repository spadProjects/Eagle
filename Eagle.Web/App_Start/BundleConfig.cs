using System.Web;
using System.Web.Optimization;

namespace Eagle.Web
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
                      "~/Content/site.css"));
            // My Bundles
            // Admin Theme Styles Bundle
            bundles.Add(new StyleBundle("~/bundles/Admin/Styles").Include(
                      "~/Content/admin/plugins/custom/fullcalendar/fullcalendar.bundle.rtl.css",
                      "~/Content/admin/plugins/global/plugins.bundle.rtl.css",
                      "~/Content/admin/plugins/custom/prismjs/prismjs.bundle.rtl.css",
                      "~/Content/admin/css/style.bundle.rtl.css",
                      "~/Content/admin/css/themes/layout/header/base/light.rtl.css",
                      "~/Content/admin/css/themes/layout/header/menu/light.rtl.css",
                      "~/Content/admin/css/themes/layout/brand/dark.rtl.css",
                      "~/Content/admin/css/themes/layout/aside/dark.rtl.css"));
            // Admin Theme Scripts Bundle
            bundles.Add(new ScriptBundle("~/bundles/Admin/Scripts").Include(
          "~/Content/admin/plugins/custom/prismjs/prismjs.bundle.js",
          "~/Content/admin/js/scripts.bundle.js",
          "~/Content/admin/plugins/custom/fullcalendar/fullcalendar.bundle.js",
          "~/Content/admin/js/pages/widgets.js"));
            // Kendo Styles
            bundles.Add(new StyleBundle("~/bundles/Kendo/Styles").Include(
          "~/Content/kendo/2020.1.114/kendo.common-nova.min.css",
          "~/Content/kendo/2020.1.114/kendo.material.min.css",
          "~/Content/kendo/2020.1.114/kendo.rtl.min.css"));
            bundles.Add(new ScriptBundle("~/bundles/Kendo/Scripts").Include(
            "~/Scripts/kendo/2020.1.114/jszip.min.js",
            "~/Scripts/kendo/2020.1.114/kendo.all.min.js",
            "~/Scripts/kendo/2020.1.114/kendo.aspnetmvc.min.js",
            "~/Scripts/kendo.modernizr.custom.js"));
            BundleTable.EnableOptimizations = true;
        }
    }
}
