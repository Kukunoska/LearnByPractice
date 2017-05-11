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
    var admin;
    (function (admin) {
        "use strict";
        var organizacii;
        (function (organizacii) {
            var IndexController = (function (_super) {
                __extends(IndexController, _super);
                function IndexController(organizacijaService, $scope) {
                    var _this = _super.call(this) || this;
                    _this.organizacijaService = organizacijaService;
                    _this.$scope = $scope;
                    _this.siteOrganizacii = [];
                    _this.vchitajOrganizacii();
                    return _this;
                }
                IndexController.prototype.izbrishi = function (organizacija) {
                    var _this = this;
                    if (confirm("Бришење на организацијата '" + organizacija.ime + "' ?")) {
                        this.organizacijaService.izbrishi(organizacija)
                            .then(function (result) {
                            _this.vchitajOrganizacii();
                        });
                    }
                };
                IndexController.prototype.vchitajOrganizacii = function () {
                    var _this = this;
                    this.organizacijaService.site()
                        .then(function (result) {
                        _this.siteOrganizacii = result;
                        _this.$scope.$apply();
                    });
                };
                return IndexController;
            }(app.base.ControllerBase));
            IndexController.$inject = [
                app.InjectionIds.organizacijaService,
                "$scope"
            ];
            organizacii.IndexController = IndexController;
            angular.module("app.admin")
                .controller(app.InjectionIds.admin_organizacii_indexController, IndexController);
        })(organizacii = admin.organizacii || (admin.organizacii = {}));
    })(admin = app.admin || (app.admin = {}));
})(app || (app = {}));
