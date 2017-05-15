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
            var OblastService = (function (_super) {
                __extends(OblastService, _super);
                function OblastService() {
                    return _super.call(this) || this;
                }
                OblastService.prototype.site = function () {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.get("api/practice/oblast/site", config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                OblastService.prototype.zemi = function (id) {
                    var config = _super.prototype.requestConfig.call(this);
                    config.params.id = id;
                    return this.$http.get("api/practice/oblast/zemi", config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                OblastService.prototype.nov = function (novaOblast) {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.post("api/practice/oblast/nov", novaOblast, config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                OblastService.prototype.izmeni = function (oblast) {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.post("api/practice/oblast/izmeni", oblast, config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                OblastService.prototype.izbrishi = function (oblast) {
                    var config = _super.prototype.requestConfig.call(this);
                    return this.$http.post("api/practice/oblast/izbrishi", oblast, config)
                        .then(function (response) {
                        return response.data;
                    });
                };
                return OblastService;
            }(services.base.ServiceBase));
            practice.OblastService = OblastService;
        })(practice = services.practice || (services.practice = {}));
    })(services = app.services || (app.services = {}));
})(app || (app = {}));
