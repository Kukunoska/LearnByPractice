var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var app;
(function (app) {
    var services;
    (function (services) {
        "use strict";
        var education;
        (function (education) {
            var PredmetiService = (function (_super) {
                __extends(PredmetiService, _super);
                function PredmetiService() {
                    _super.call(this);
                }
                PredmetiService.prototype.site = function () {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.get("api/admin/predmeti/site", config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                return PredmetiService;
            }(services.base.ServiceBase));
            education.PredmetiService = PredmetiService;
            angular
                .module("app.services")
                .service(app.InjectionIds.predmetiService, PredmetiService);
        })(education = services.education || (services.education = {}));
    })(services = app.services || (app.services = {}));
})(app || (app = {}));
//# sourceMappingURL=predmetiservice.js.map