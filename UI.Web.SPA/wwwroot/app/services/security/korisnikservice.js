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
        var security;
        (function (security) {
            var KorisnikService = (function (_super) {
                __extends(KorisnikService, _super);
                function KorisnikService() {
                    return _super.call(this) || this;
                }
                KorisnikService.prototype.tekoven = function () {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.get("api/security/korisnik/tekoven", config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                return KorisnikService;
            }(services.base.ServiceBase));
            security.KorisnikService = KorisnikService;
            angular
                .module("app.services")
                .service(app.InjectionIds.korisnikService, KorisnikService);
        })(security = services.security || (services.security = {}));
    })(services = app.services || (app.services = {}));
})(app || (app = {}));
