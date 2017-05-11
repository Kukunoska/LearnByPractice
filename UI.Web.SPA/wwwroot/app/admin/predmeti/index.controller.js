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
        var predmeti;
        (function (predmeti) {
            var IndexController = (function (_super) {
                __extends(IndexController, _super);
                function IndexController(predmetService, $scope) {
                    var _this = _super.call(this) || this;
                    _this.predmetService = predmetService;
                    _this.sitePredmeti = [];
                    _this.predmetService.site()
                        .then(function (result) {
                        _this.sitePredmeti = result;
                        $scope.$apply();
                    });
                    return _this;
                }
                return IndexController;
            }(app.base.ControllerBase));
            IndexController.$inject = [
                app.InjectionIds.predmetService,
                "$scope"
            ];
            predmeti.IndexController = IndexController;
            angular.module("app.admin")
                .controller(app.InjectionIds.admin_predmeti_indexController, IndexController);
        })(predmeti = admin.predmeti || (admin.predmeti = {}));
    })(admin = app.admin || (app.admin = {}));
})(app || (app = {}));
