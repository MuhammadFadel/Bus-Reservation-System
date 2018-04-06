using System.Web;
using System.Web.Optimization;

namespace Bus_Reservation_System
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
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


            //"~/Content/Assets/web/assets/jquery/jquery.min.js",
            bundles.Add(new ScriptBundle("~/bundles/TempScript").Include(
                      "~/Content/Assets/bootstrap/js/bootstrap.min.js",
                      "~/Scripts/respond.js",
                      "~/Content/Assets/popper/popper.min.js",
                      "~/Content/Assets/tether/tether.min.js",
                      "~/Content/Assets/smoothscroll/smooth-scroll.js",
                      "~/Content/Assets/dropdown/js/script.min.js",
                      "~/Content/Assets/touchswipe/jquery.touch-swipe.min.js",
                      "~/Content/Assets/touchswipe/jquery.touch-swipe.min.js",
                      "~/Content/Assets/parallax/jarallax.min.js",
                      "~/Content/Assets/masonry/masonry.pkgd.min.js",
                      "~/Content/Assets/imagesloaded/imagesloaded.pkgd.min.js",
                      "~/Content/Assets/sociallikes/social-likes.js",
                      "~/Content/Assets/vimeoplayer/jquery.mb.vimeo_player.js",
                      "~/Content/Assets/mbr-testimonials-slider/mbr-testimonials-slider.js",
                      "~/Content/Assets/bootstrapcarouselswipe/bootstrap-carousel-swipe.js",
                      "~/Content/Assets/theme/js/script.js",
                      "~/Content/Assets/slidervideo/script.js",
                      "~/Content/Assets/gallery/player.min.js",
                      "~/Content/Assets/formoid/formoid.min.js"));



            bundles.Add(new StyleBundle("~/Content/TempStyle").Include(
                      "~/Content/Assets/bootstrap/css/bootstrap.min.css",
                      "~/Content/Assets/web/assets/mobirise-icons/mobirise-icons.css",
                      "~/Content/Assets/tether/tether.min.css",
                      "~/Content/Assets/bootstrap/css/bootstrap-grid.min.css",
                      "~/Content/Assets/bootstrap/css/bootstrap-reboot.min.css",
                      "~/Content/Assets/dropdown/css/style.css",
                      "~/Content/Assets/socicon/css/styles.css",
                      "~/Content/Assets/socicon/css/styles.css",
                      "~/Content/Assets/theme/css/style.css",
                      "~/Content/Assets/gallery/style.css",
                      "~/Content/Assets/mobirise/css/mbr-additional.css"));

        }
    }
}
