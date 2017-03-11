var app;
(function (app) {
    "use strict";
    var Config = (function () {
        function Config($stateProvider, $urlRouteProvider) {
            var baseUrl = $("base").first().attr("href");
            var pochetnaConfig = {
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
            var adminConfig = {
                name: "admin",
                url: "/admin",
                abstract: true
            };
            $stateProvider.state("admin", adminConfig);
            var predmetiConfig = {
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
        }
        Config.$inject = [
            "$stateProvider",
            "$urlRouterProvider",
        ];
        return Config;
    }());
    angular
        .module("app")
        .config(Config);
})(app || (app = {}));
//# sourceMappingURL=app.js.map