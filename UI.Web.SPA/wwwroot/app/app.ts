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

            let kompaniiConfig: ng.ui.IState = {
                name: "admin.kompanii",
                url: "/kompanii",
                views: {
                    "@": {
                        templateUrl: "/wwwroot/app/admin/kompanii/index.html",
                        controller: app.InjectionIds.admin_kompanii_indexController,
                        controllerAs: "vm"
                    }
                }
            };
            $stateProvider.state("admin.kompanii", kompaniiConfig);

            let vnesiKompanijaConfig: ng.ui.IState = {
                name: "admin.kompanii.vnesuvanje",
                url: "/vnesuvanje/{id:int}",
                views: {
                    "@": {
                        templateUrl: "/wwwroot/app/admin/kompanii/vnesuvanje.html",
                        controller: app.InjectionIds.admin_kompanii_vnesuvanjeController,
                        controllerAs: "vm"
                    }
                }
            };
            $stateProvider.state("admin.kompanii.vnesuvanje", vnesiKompanijaConfig);
        }
    }

    angular
        .module("app")
        .config(Config);
}
