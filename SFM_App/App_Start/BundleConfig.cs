using System.Web;
using System.Web.Optimization;

namespace SFM_App
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region Scripts
            bundles.Add(new ScriptBundle("~/bundles/jqueryjs").Include(
                "~/Scripts/jquery.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapjs").Include(
                "~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/Chartjs").Include(
                "~/Scripts/Chart.js"));

            bundles.Add(new ScriptBundle("~/bundles/html5shivjs").Include(
                "~/Scripts/html5shiv.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquerypluginsjs").Include(
                "~/Scripts/jquery.themepunch.plugins.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryrevolutionjs").Include(
                "~/Scripts/jquery.themepunch.revolution.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizrjs").Include(
                "~/Scripts/modernizr.custom.79639.js"));

            bundles.Add(new ScriptBundle("~/bundles/slideshowjs").Include(
                "~/Scripts/SlideShow.js"));
            #endregion

            #region CSS
            bundles.Add(new ScriptBundle("~/bundles/bootstrapcss").Include(
                "~/Content/bootstrap.css"));

            bundles.Add(new ScriptBundle("~/bundles/flat-uicss").Include(
                "~/Content/flat-ui.css"));

            bundles.Add(new ScriptBundle("~/bundles/maincss").Include(
                "~/Content/main.css"));

            bundles.Add(new ScriptBundle("~/bundles/media-slideshowcss").Include(
                "~/Content/media-slideshow.css"));

            bundles.Add(new ScriptBundle("~/bundles/revolutioncss").Include(
                "~/Content/revolution.css"));
            #endregion
        }
    }
}
