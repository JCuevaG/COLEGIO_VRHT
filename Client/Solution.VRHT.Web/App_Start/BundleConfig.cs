using System.Web;
using System.Web.Optimization;

namespace Solution.VRHT.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/UserControl.Helper.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            //add
            bundles.Add(new ScriptBundle("~/bundles/Complement").Include(
                       "~/Scripts/Jquery/modernizr.min.js",
                       "~/Scripts/Jquery/jquery-migrate-1.2.1.min.js",
                       "~/Scripts/Jquery/jquery.pjax.js"
                       ));

            // add drag and drop
            bundles.Add(new ScriptBundle("~/bundles/dropzonescripts").Include(
                     "~/Scripts/dropzone/dropzone.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));



            // add drag and drop
            bundles.Add(new StyleBundle("~/Content/dropzonescss").Include(
                      "~/Scripts/dropzone/css/basic.css",
                      "~/Scripts/dropzone/css/dropzone.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                "~/Content/bootstrap/bootstrap-theme.css"

                ));

            //add
            bundles.Add(new ScriptBundle("~/Content/bootstrapJs").Include(
                        "~/Scripts/bootstrapJS/bootstrap.min.js",
                        "~/Scripts/Jquery/jquery.nicescroll.js",
                        "~/Scripts/Jquery/bootstrap/scripts.js"
                        ));

            //add
            bundles.Add(new StyleBundle("~/Content/css/StylePage").Include(
                        "~/Content/css/style.css",
                        "~/Content/css/index.css",
                        "~/Content/css/login.css",
                        "~/Content/css/general.css",
                        "~/Content/css/style-responsive.css"
            ));


            //add by marcos
            bundles.Add(new StyleBundle("~/Scripts/Login").Include(
                "~/Scripts/Login/bootstrap.min.css",
                "~/Scripts/Login/pixel-admin.min.css",
                "~/Scripts/Login/pages.min.css",
                "~/Scripts/Login/rtl.min.css",
                "~/Scripts/Login/themes.min.css"
                ));

        }
    }
}