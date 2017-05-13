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
        var studiskiprogrami;
        (function (studiskiprogrami) {
            var IndexController = (function (_super) {
                __extends(IndexController, _super);
                function IndexController(studiskaProgramaService, $scope) {
                    var _this = _super.call(this) || this;
                    _this.studiskaProgramaService = studiskaProgramaService;
                    _this.$scope = $scope;
                    _this.siteStudiskiProgrami = [];
                    _this.vchitajStudiskaPrograma();
                    return _this;
                }
                IndexController.prototype.izbrishi = function (studiskaprograma) {
                    var _this = this;
                    if (confirm("Бришење на студиска програма '" + studiskaprograma.ime + "' ?")) {
                        this.studiskaProgramaService.izbrishi(studiskaprograma)
                            .then(function (result) {
                            _this.vchitajStudiskaPrograma();
                        });
                    }
                };
                IndexController.prototype.vchitajStudiskaPrograma = function () {
                    var _this = this;
                    this.studiskaProgramaService.site()
                        .then(function (result) {
                        _this.siteStudiskiProgrami = result;
                        _this.$scope.$apply();
                    });
                };
                return IndexController;
            }(app.base.ControllerBase));
            IndexController.$inject = [
                app.InjectionIds.studiskaProgramaService,
                "$scope"
            ];
            studiskiprogrami.IndexController = IndexController;
            angular.module("app.admin")
                .controller(app.InjectionIds.admin_studiskiProgrami_indexController, IndexController);
        })(studiskiprogrami = admin.studiskiprogrami || (admin.studiskiprogrami = {}));
    })(admin = app.admin || (app.admin = {}));
})(app || (app = {}));
//# sourceMappingURL=index.controller.js.map