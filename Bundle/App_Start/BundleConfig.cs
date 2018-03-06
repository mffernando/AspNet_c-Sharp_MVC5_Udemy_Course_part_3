using System.Web;
using System.Web.Optimization;

namespace Bundle
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            //enable bundles
            BundleTable.EnableOptimizations = true;

            //new bundle
            //all JavaScript = *.js / subdirectories = true
            bundles.Add(new ScriptBundle("~/common").IncludeDirectory(
                "~/Scripts/common", "*.js", true));

            //skip extension .dbg.js
            bundles.IgnoreList.Ignore("*.dbg.js");

            //ordening the .js archives to execution
            var order = new BundleFileSetOrdering("ordening");
            order.Files.Add("~/common/example.js");
            order.Files.Add("~/common/display.js");
            bundles.FileSetOrderList.Insert(0, order);

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
