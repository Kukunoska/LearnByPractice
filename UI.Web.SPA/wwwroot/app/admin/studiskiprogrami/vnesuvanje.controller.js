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
            var VnesuvanjeController = (function (_super) {
                __extends(VnesuvanjeController, _super);
                function VnesuvanjeController(studiskaProgramaService, $scope, $state, $stateParams) {
                    var _this = _super.call(this) || this;
                    _this.studiskaProgramaService = studiskaProgramaService;
                    _this.$state = $state;
                    _this.$stateParams = $stateParams;
                    _this.studiskaprograma = new app.model.education.StudiskaPrograma();
                    var vm = _this;
                    var studiskaprogramaid = 0;
                    if (vm.$stateParams["id"] != null) {
                        studiskaprogramaid = parseInt(_this.$stateParams["id"], 10);
                        if (studiskaprogramaid !== 0) {
                            vm.studiskaProgramaService.zemi(studiskaprogramaid)
                                .then(function (result) {
                                vm.studiskaprograma = result;
                                $scope.$apply();
                            });
                        }
                    }
                    vm.novZapis = studiskaprogramaid === 0;
                    vm.izmena = !vm.novZapis;
                    $scope.$apply();
                    return _this;
                }
                VnesuvanjeController.prototype.zapishi = function () {
                    var _this = this;
                    if (this.novZapis) {
                        this.studiskaProgramaService.nov(this.studiskaprograma)
                            .then(function (result) {
                            _this.$state.go("admin.studiskiProgrami");
                        });
                    }
                    else {
                        this.studiskaProgramaService.izmeni(this.studiskaprograma)
                            .then(function (result) {
                            _this.$state.go("admin.studiskiProgrami");
                        });
                    }
                };
                VnesuvanjeController.prototype.otkazhiSe = function () {
                    this.$state.go("admin.studiskiProgrami");
                };
                return VnesuvanjeController;
            }(app.base.ControllerBase));
            VnesuvanjeController.$inject = [
                app.InjectionIds.studiskaProgramaService,
                "$scope",
                "$state",
                "$stateParams"
            ];
            studiskiprogrami.VnesuvanjeController = VnesuvanjeController;
            angular.module("app.admin")
                .controller(app.InjectionIds.admin_studiskiProgrami_vnesuvanjeController, VnesuvanjeController);
        })(studiskiprogrami = admin.studiskiprogrami || (admin.studiskiprogrami = {}));
    })(admin = app.admin || (app.admin = {}));
})(app || (app = {}));
//# sourceMappingURL=vnesuvanje.controller.js.map