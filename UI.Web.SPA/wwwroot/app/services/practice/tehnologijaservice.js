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
        var practice;
        (function (practice) {
            var TehnologijaService = (function (_super) {
                __extends(TehnologijaService, _super);
                function TehnologijaService() {
                    return _super.call(this) || this;
                }
                TehnologijaService.prototype.site = function () {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.get("api/practice/tehnologija/site", config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                TehnologijaService.prototype.zemi = function (id) {
                    var config = _super.prototype.requestConfig.call(this);
                    config.params.id = id;
                    return this.$http.get("api/practice/tehnologija/zemi", config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                TehnologijaService.prototype.nov = function (novaTehnologija) {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.post("api/practice/tehnologija/nov", novaTehnologija, config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                TehnologijaService.prototype.izmeni = function (tehnologija) {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.post("api/practice/tehnologija/izmeni", tehnologija, config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                TehnologijaService.prototype.izbrishi = function (tehnologija) {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.post("api/practice/tehnologija/izbrishi", tehnologija, config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                return TehnologijaService;
            }(services.base.ServiceBase));
            practice.TehnologijaService = TehnologijaService;
        })(practice = services.practice || (services.practice = {}));
    })(services = app.services || (app.services = {}));
})(app || (app = {}));
