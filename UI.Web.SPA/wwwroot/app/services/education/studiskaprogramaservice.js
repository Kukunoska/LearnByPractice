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
            var StudiskaProgramaService = (function (_super) {
                __extends(StudiskaProgramaService, _super);
                function StudiskaProgramaService() {
                    return _super.call(this) || this;
                }
                StudiskaProgramaService.prototype.site = function () {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.get("api/education/studiskaprograma/site", config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                StudiskaProgramaService.prototype.nova = function (novaStudiskaPrograma) {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.post("api/education/studiskaprograma/nova", novaStudiskaPrograma, config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                StudiskaProgramaService.prototype.izmeni = function (studiskaprograma) {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.post("api/education/studiskaprograma/izmeni", studiskaprograma, config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                return StudiskaProgramaService;
            }(services.base.ServiceBase));
            education.StudiskaProgramaService = StudiskaProgramaService;
            angular
                .module("app.services")
                .service(app.InjectionIds.studiskaprogramaService, StudiskaProgramaService);
        })(education = services.education || (services.education = {}));
    })(services = app.services || (app.services = {}));
})(app || (app = {}));
