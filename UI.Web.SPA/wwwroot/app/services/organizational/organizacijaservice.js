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
        var organizational;
        (function (organizational) {
            var OrganizacijaService = (function (_super) {
                __extends(OrganizacijaService, _super);
                function OrganizacijaService() {
                    return _super.call(this) || this;
                }
                OrganizacijaService.prototype.site = function () {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.get("api/organizational/organizacija/site", config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                OrganizacijaService.prototype.zemi = function (id) {
                    var config = _super.prototype.requestConfig.call(this);
                    config.params.id = id;
                    return this.$http.get("api/organizational/organizacija/zemi", config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                OrganizacijaService.prototype.nova = function (organizacija) {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.post("api/organizational/organizacija/nova", organizacija, config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                OrganizacijaService.prototype.izmeni = function (organizacija) {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.post("api/organizational/organizacija/izmeni", organizacija, config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                OrganizacijaService.prototype.izbrishi = function (organizacija) {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.post("api/organizational/organizacija/izbrishi", organizacija, config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                return OrganizacijaService;
            }(services.base.ServiceBase));
            organizational.OrganizacijaService = OrganizacijaService;
            angular
                .module("app.services")
                .service(app.InjectionIds.organizacijaService, OrganizacijaService);
        })(organizational = services.organizational || (services.organizational = {}));
    })(services = app.services || (app.services = {}));
})(app || (app = {}));
