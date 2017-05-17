module app {
    "use strict";

    class Config {

        static $inject = [
            "$stateProvider",
            "$urlRouterProvider",
        ];

        constructor(
            $stateProvider: ng.ui.IStateProvider,
            $urlRouteProvider: ng.ui.IUrlRouterProvider) {

            // општо за сите видови корисници
            let pochetnaConfig: ng.ui.IState = {
                name: "pochetna",
                url: "/",
                views: {
                    "@": {
                        templateUrl: "/wwwroot/app/index.html",
                        controller: app.InjectionIds.indexController,
                        controllerAs: "vm"
                    }
                }
            };
            $stateProvider.state("pochetna", pochetnaConfig);

            let editProfileConfig: ng.ui.IState = {
                name: "editprofile",
                url: "/editprofile",
                views: {
                    "@": {
                        templateUrl: "/wwwroot/app/user/editprofile.html",
                        controller: app.InjectionIds.user_editProfileController,
                        controllerAs: "vm"
                    }
                }
            };
            $stateProvider.state("editprofile", editProfileConfig);

            let changePasswordConfig: ng.ui.IState = {
                name: "changepassword",
                url: "/changepassword",
                views: {
                    "@": {
                        templateUrl: "/wwwroot/app/user/changepassword.html",
                        controller: app.InjectionIds.user_changePasswordController,
                        controllerAs: "vm"
                    }
                }
            };
            $stateProvider.state("changepassword", changePasswordConfig);

            // администратор
            let adminHomeConfig: ng.ui.IState = {
                name: "admin",
                url: "/admin",
                views: {
                    "@": {
                        templateUrl: "/wwwroot/app/admin/home/home.html",
                        controller: app.InjectionIds.admin_homeController,
                        controllerAs: "vm"
                    }
                }
            };
            $stateProvider.state("admin", adminHomeConfig);

            let predmetiConfig: ng.ui.IState = {
                name: "admin.predmeti",
                url: "/predmeti",
                views: {
                    "@": {
                        templateUrl: "/wwwroot/app/admin/predmeti/index.html",
                        controller: app.InjectionIds.admin_predmeti_indexController,
                        controllerAs: "vm"
                    }
                }
            };
            $stateProvider.state("admin.predmeti", predmetiConfig);

            let vnesiPredmetConfig: ng.ui.IState = {
                name: "admin.predmeti.vnesuvanje",
                url: "/vnesuvanje/{id:int}",
                views: {
                    "@": {
                        templateUrl: "/wwwroot/app/admin/predmeti/vnesuvanje.html",
                        controller: app.InjectionIds.admin_predmeti_vnesuvanjeController,
                        controllerAs: "vm"
                    }
                }
            };
            $stateProvider.state("admin.predmeti.vnesuvanje", vnesiPredmetConfig);

            let vidoviOrganizaciiConfig: ng.ui.IState = {
                name: "admin.vidoviorganizacii",
                url: "/vidoviorganizacii",
                views: {
                    "@": {
                        templateUrl: "/wwwroot/app/admin/vidoviorganizacii/index.html",
                        controller: app.InjectionIds.admin_vidoviOrganizacii_indexController,
                        controllerAs: "vm"
                    }
                }
            };
            $stateProvider.state("admin.vidoviorganizacii", vidoviOrganizaciiConfig);

            let vnesiVidOrganizacijaConfig: ng.ui.IState = {
                name: "admin.vidoviorganizacii.vnesuvanje",
                url: "/vnesuvanje/{id:int}",
                views: {
                    "@": {
                        templateUrl: "/wwwroot/app/admin/vidoviorganizacii/vnesuvanje.html",
                        controller: app.InjectionIds.admin_vidoviOrganizacii_vnesuvanjeController,
                        controllerAs: "vm"
                    }
                }
            };
            $stateProvider.state("admin.vidoviorganizacii.vnesuvanje", vnesiVidOrganizacijaConfig);

            let organizaciiConfig: ng.ui.IState = {
                name: "admin.organizacii",
                url: "/organizacii",
                views: {
                    "@": {
                        templateUrl: "/wwwroot/app/admin/organizacii/index.html",
                        controller: app.InjectionIds.admin_organizacii_indexController,
                        controllerAs: "vm"
                    }
                }
            };
            $stateProvider.state("admin.organizacii", organizaciiConfig);

            let vnesiOrganizacijaConfig: ng.ui.IState = {
                name: "admin.organizacii.vnesuvanje",
                url: "/vnesuvanje/{id:int}",
                views: {
                    "@": {
                        templateUrl: "/wwwroot/app/admin/organizacii/vnesuvanje.html",
                        controller: app.InjectionIds.admin_organizacii_vnesuvanjeController,
                        controllerAs: "vm"
                    }
                }
            };
            $stateProvider.state("admin.organizacii.vnesuvanje", vnesiOrganizacijaConfig);

            let studiskaProgramaConfig: ng.ui.IState = {
                name: "admin.studiskiprogrami",
                url: "/studiskiprogrami",
                views: {
                    "@": {
                        templateUrl: "/wwwroot/app/admin/studiskiprogrami/index.html",
                        controller: app.InjectionIds.admin_studiskiProgrami_indexController,
                        controllerAs: "vm"
                    }
                }
            };
            $stateProvider.state("admin.studiskiprogrami", studiskaProgramaConfig);

            let vnesiStudiskaProgramaConfig: ng.ui.IState = {
                name: "admin.studiskiprogrami.vnesuvanje",
                url: "/vnesuvanje/{id:int}",
                views: {
                    "@": {
                        templateUrl: "/wwwroot/app/admin/studiskiprogrami/vnesuvanje.html",
                        controller: app.InjectionIds.admin_studiskiProgrami_vnesuvanjeController,
                        controllerAs: "vm"
                    }
                }
            };
            $stateProvider.state("admin.studiskiprogrami.vnesuvanje", vnesiStudiskaProgramaConfig);

            let oblastConfig: ng.ui.IState = {
                name: "admin.oblasti",
                url: "/oblasti",
                views: {
                    "@": {
                        templateUrl: "/wwwroot/app/admin/oblasti/index.html",
                        controller: app.InjectionIds.admin_oblasti_indexController,
                        controllerAs: "vm"
                    }
                }
            };
            $stateProvider.state("admin.oblasti", oblastConfig);

            let vnesiOblastConfig: ng.ui.IState = {
                name: "admin.oblasti.vnesuvanje",
                url: "/vnesuvanje/{id:int}",
                views: {
                    "@": {
                        templateUrl: "/wwwroot/app/admin/oblasti/vnesuvanje.html",
                        controller: app.InjectionIds.admin_oblasti_vnesuvanjeController,
                        controllerAs: "vm"
                    }
                }
            };
            $stateProvider.state("admin.oblasti.vnesuvanje", vnesiOblastConfig);

            let tehnologijaConfig: ng.ui.IState = {
                name: "admin.tehnologii",
                url: "/tehnologii",
                views: {
                    "@": {
                        templateUrl: "/wwwroot/app/admin/tehnologii/index.html",
                        controller: app.InjectionIds.admin_tehnologii_indexController,
                        controllerAs: "vm"
                    }
                }
            };
            $stateProvider.state("admin.tehnologii", tehnologijaConfig);

            let vnesiTehnologijaConfig: ng.ui.IState = {
                name: "admin.tehnologii.vnesuvanje",
                url: "/vnesuvanje/{id:int}",
                views: {
                    "@": {
                        templateUrl: "/wwwroot/app/admin/tehnologii/vnesuvanje.html",
                        controller: app.InjectionIds.admin_tehnologii_vnesuvanjeController,
                        controllerAs: "vm"
                    }
                }
            };
            $stateProvider.state("admin.tehnologii.vnesuvanje", vnesiTehnologijaConfig);

            let korisnikConfig: ng.ui.IState = {
                name: "admin.korisnici",
                url: "/korisnici",
                views: {
                    "@": {
                        templateUrl: "/wwwroot/app/admin/korisnici/index.html",
                        controller: app.InjectionIds.admin_korisnici_indexController,
                        controllerAs: "vm"
                    }
                }
            };
            $stateProvider.state("admin.korisnici", korisnikConfig);

            let vnesiKorisnikConfig: ng.ui.IState = {
                name: "admin.korisnici.vnesuvanje",
                url: "/vnesuvanje/{id:int}",
                views: {
                    "@": {
                        templateUrl: "/wwwroot/app/admin/korisnici/vnesuvanje.html",
                        controller: app.InjectionIds.admin_korisnici_vnesuvanjeController,
                        controllerAs: "vm"
                    }
                }
            };
            $stateProvider.state("admin.korisnici.vnesuvanje", vnesiKorisnikConfig);


            // ментор
            let mentorHomeConfig: ng.ui.IState = {
                name: "mentor",
                url: "/mentor",
                views: {
                    "@": {
                        templateUrl: "/wwwroot/app/mentor/home/home.html",
                        controller: app.InjectionIds.mentor_homeController,
                    }
                }
            };
            $stateProvider.state("mentor", mentorHomeConfig);


            // студент
            let studentHomeConfig: ng.ui.IState = {
                name: "student",
                url: "/student",
                views: {
                    "@": {
                        templateUrl: "/wwwroot/app/student/home/home.html",
                        controller: app.InjectionIds.student_homeController,
                    }
                }
            };
            $stateProvider.state("student", studentHomeConfig);
        }     
    }
    angular
        .module("app")
        .config(Config);
}
