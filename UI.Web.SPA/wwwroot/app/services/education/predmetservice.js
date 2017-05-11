var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var app;
(function (app) {
    var services;
    (function (services) {
        "use strict";
        var education;
        (function (education) {
            var PredmetService = (function (_super) {
                __extends(PredmetService, _super);
                function PredmetService() {
                    return _super.call(this) || this;
                }
                PredmetService.prototype.site = function () {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.get("api/education/predmet/site", config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                PredmetService.prototype.zemi = function (id) {
                    var config = _super.prototype.requestConfig.call(this);
                    config.params.id = id;
                    return this.$http.get("api/education/predmet/zemi", config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                PredmetService.prototype.nov = function (novPredmet) {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.post("api/education/predmet/nov", novPredmet, config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                PredmetService.prototype.izmeni = function (predmet) {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.post("api/education/predmet/izmeni", predmet, config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                PredmetService.prototype.izbrishi = function (predmet) {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.post("api/education/predmet/izbrishi", predmet, config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                return PredmetService;
            }(services.base.ServiceBase));
            education.PredmetService = PredmetService;
            angular
                .module("app.services")
                .service(app.InjectionIds.predmetService, PredmetService);
        })(education = services.education || (services.education = {}));
    })(services = app.services || (app.services = {}));
})(app || (app = {}));
