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


            let adminConfig: ng.ui.IState = {
                name: "admin",
                url: "/admin",
                abstract: true
            };
            $stateProvider.state("admin", adminConfig);

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
        }
    }

    angular
        .module("app")
        .config(Config);
}
