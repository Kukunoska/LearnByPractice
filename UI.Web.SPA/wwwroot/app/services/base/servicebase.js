var app;
(function (app) {
    var services;
    (function (services) {
        "use strict";
        var base;
        (function (base) {
            var ServiceBase = (function () {
                function ServiceBase() {
                    var $injector = angular.injector(["ng"]);
                    this.$http = $injector.get("$http");
                }
                ServiceBase.prototype.requestConfig = function () {
                    var config = {
                        params: {}
                    };
                    return config;
                };
                return ServiceBase;
            }());
            base.ServiceBase = ServiceBase;
        })(base = services.base || (services.base = {}));
    })(services = app.services || (app.services = {}));
})(app || (app = {}));
//# sourceMappingURL=servicebase.js.map