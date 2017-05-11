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
            var VidOrganizacijaService = (function (_super) {
                __extends(VidOrganizacijaService, _super);
                function VidOrganizacijaService() {
                    return _super.call(this) || this;
                }
                VidOrganizacijaService.prototype.site = function () {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.get("api/organizational/vidorganizacija/site", config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                VidOrganizacijaService.prototype.zemi = function (id) {
                    var config = _super.prototype.requestConfig.call(this);
                    config.params.id = id;
                    return this.$http.get("api/organizational/vidorganizacija/zemi", config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                VidOrganizacijaService.prototype.nov = function (vidOrganizacija) {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.post("api/organizational/vidorganizacija/nov", vidOrganizacija, config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                VidOrganizacijaService.prototype.izmeni = function (vidOrganizacija) {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.post("api/organizational/vidorganizacija/izmeni", vidOrganizacija, config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                VidOrganizacijaService.prototype.izbrishi = function (vidOrganizacija) {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.post("api/organizational/vidorganizacija/izbrishi", vidOrganizacija, config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                return VidOrganizacijaService;
            }(services.base.ServiceBase));
            organizational.VidOrganizacijaService = VidOrganizacijaService;
            angular
                .module("app.services")
                .service(app.InjectionIds.vidOrganizacijaService, VidOrganizacijaService);
        })(organizational = services.organizational || (services.organizational = {}));
    })(services = app.services || (app.services = {}));
})(app || (app = {}));
