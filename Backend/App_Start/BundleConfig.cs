using System.Web;
using System.Web.Optimization;

namespace MainProject
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").Include(

           ));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                 "~/Scripts/jquery-3.4.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
              "~/Scripts/jquery.validate.min.js",
              // Ajax.BeginForm
              "~/Scripts/jquery.unobtrusive-ajax.min.js",
              // Html.BeginForm
              "~/Scripts/jquery.validate.unobtrusive.min.js"
           ));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                // Switch language
                "~/Scripts/MainProject/CommonController.js"
            ));
        }
    }
}
