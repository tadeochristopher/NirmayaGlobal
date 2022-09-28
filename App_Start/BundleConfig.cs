using System.Web.Optimization;

namespace NirmayaGlobal.App_Start
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/Script/").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/Scripts/").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/Scripts/CanvasArc").Include(
                        "~/CanvasArc/manageCanvas.js"));

            //bundles.Add( new ScriptBundle( "~/bundles/bootstrap" ).Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js" ) );

            bundles.Add(new StyleBundle("~/Content/Styles").Include(
                      "~/Content/Styles/NGStyler.css"));
        }
    }
}