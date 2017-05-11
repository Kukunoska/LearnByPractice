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
            var OcenaService = (function (_super) {
                __extends(OcenaService, _super);
                function OcenaService() {
                    return _super.call(this) || this;
                }
                OcenaService.prototype.site = function () {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.get("app/education/ocena/site", config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                OcenaService.prototype.zemi = function (id) {
                    var config = _super.prototype.requestConfig.call(this);
                    config.params.id = id;
                    return this.$http.get("app/education/ocena/zemi", config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                OcenaService.prototype.nov = function (novaOcena) {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.post("app/education/ocena/nov", novaOcena, config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                OcenaService.prototype.izmeni = function (ocena) {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.post("app/education/ocena/izmeni", ocena, config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                OcenaService.prototype.izbrishi = function (ocena) {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.post("app/education/ocena/izbrishi", ocena, config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                return OcenaService;
            }(services.base.ServiceBase));
            education.OcenaService = OcenaService;
            angular
                .module("app.services")
                .service(app.InjectionIds.ocenaService, OcenaService);
        })(education = services.education || (services.education = {}));
    })(services = app.services || (app.services = {}));
})(app || (app = {}));
