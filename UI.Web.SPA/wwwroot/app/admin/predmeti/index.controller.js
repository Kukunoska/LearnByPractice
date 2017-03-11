var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var app;
(function (app) {
    var admin;
    (function (admin) {
        "use strict";
        var predmeti;
        (function (predmeti) {
            var IndexController = (function (_super) {
                __extends(IndexController, _super);
                function IndexController(predmetiService, $scope) {
                    var _this = this;
                    _super.call(this);
                    this.predmetiService = predmetiService;
                    this.sitePredmeti = [];
                    this.predmetiService.site()
                        .then(function (result) {
                        _this.sitePredmeti = result;
                        $scope.$apply();
                    });
                }
                IndexController.$inject = [
                    app.InjectionIds.predmetiService,
                    "$scope"
                ];
                return IndexController;
            }(app.base.ControllerBase));
            predmeti.IndexController = IndexController;
            angular.module("app.admin")
                .controller(app.InjectionIds.admin_predmeti_indexController, IndexController);
        })(predmeti = admin.predmeti || (admin.predmeti = {}));
    })(admin = app.admin || (app.admin = {}));
})(app || (app = {}));
//# sourceMappingURL=index.controller.js.map