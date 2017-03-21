using System;
using System.Web.Optimization;

namespace LearnByPractice.UI.Web
{
    public static class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            if (bundles == null) throw new ArgumentNullException("bundles");

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                LibFile("bootstrap/dist/css/bootstrap.css"),
                LibFile("bootstrap/dist/css/bootstrap-theme.css"),
                LibFile("Font-Awesome/css/font-awesome.css"),

                AppFile("styles/Site.css")
            ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-2.8.3.js"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                LibFile("jquery/dist/jquery.js"),
                LibFile("bootstrap/dist/js/bootstrap.js"),
                LibFile("angular/angular.js"),
                LibFile("angular-bootstrap/ui-bootstrap.js"),
                LibFile("angular-bootstrap/ui-bootstrap-tpls.js"),
                LibFile("angular-ui-router/release/angular-ui-router.js"),
                LibFile("angular-animate/angular-animate.js")
                ));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                AppFile("app.module.js"),
                AppFile("injectionids.js"),
                AppFile("app.js"),

                // Model
                ModelFile("model.module.js"),
                ModelFile("education/predmet.js"),
                ModelFile("security/korisnik.js"),
                ModelFile("organizational/vidorganizacija.js"),
                ModelFile("organizational/organizacija.js"),

                // Services
                ServiceFile("services.module.js"),
                ServiceFile("base/servicebase.js"),

                ServiceFile("education/ipredmetservice.js"),
                ServiceFile("education/predmetservice.js"),

                ServiceFile("organizational/ividorganizacijaservice.js"),
                ServiceFile("organizational/vidorganizacijaservice.js"),

                ServiceFile("organizational/iorganizacijaservice.js"),
                ServiceFile("organizational/organizacijaservice.js"),

                ServiceFile("security/ikorisnikservice.js"),
                ServiceFile("security/korisnikservice.js"),

                // Base
                AppFile("base/base.module.js"),
                AppFile("base/controllerbase.js"),

                // Shell
                AppFile("shell.controller.js"),

                // Controllers
                AppFile("index.controller.js"),

                AppFile("user/user.module.js"),
                AppFile("user/changepassword.controller.js"),
                AppFile("user/editprofile.controller.js"),

                AppFile("admin/admin.module.js"),

                AppFile("admin/predmeti/index.controller.js"),
                
                AppFile("admin/vidoviorganizacii/index.controller.js"),
                AppFile("admin/vidoviorganizacii/vnesuvanje.controller.js"),

                AppFile("admin/organizacii/index.controller.js"),
                AppFile("admin/organizacii/vnesuvanje.controller.js")
                ));
        }

        private static string LibFile(string filePath)
        {
            return string.Concat("~/wwwroot/lib/", filePath);
        }

        private static string AppFile(string filePath)
        {
            return string.Concat("~/wwwroot/app/", filePath);
        }

        private static string ModelFile(string filePath)
        {
            return AppFile(string.Concat("model/", filePath));
        }

        private static string ServiceFile(string filePath)
        {
            return AppFile(string.Concat("services/", filePath));
        }
    }
}