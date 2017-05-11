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
            var VnesuvanjeController = (function (_super) {
                __extends(VnesuvanjeController, _super);
                function VnesuvanjeController(predmetService, $scope, $state, $stateParams) {
                    var _this = _super.call(this) || this;
                    _this.predmetService = predmetService;
                    _this.$state = $state;
                    _this.$stateParams = $stateParams;
                    _this.predmet = new app.model.education.Predmet();
                    var vm = _this;
                    var predmetId = 0;
                    if (vm.$stateParams["id"] != null) {
                        predmetId = parseInt(_this.$stateParams["id"], 10);
                        if (predmetId !== 0) {
                            vm.predmetService.zemi(predmetId)
                                .then(function (result) {
                                vm.predmet = result;
                                $scope.$apply();
                            });
                        }
                    }
                    vm.novZapis = predmetId === 0;
                    vm.izmena = !vm.novZapis;
                    return _this;
                }
                VnesuvanjeController.prototype.zapishi = function () {
                    var _this = this;
                    if (this.novZapis) {
                        this.predmetService.nov(this.predmet)
                            .then(function (result) {
                            _this.$state.go("admin.predmeti");
                        });
                    }
                    else {
                        this.predmetService.izmeni(this.predmet)
                            .then(function (result) {
                            _this.$state.go("admin.predmeti");
                        });
                    }
                };
                VnesuvanjeController.prototype.otkazhiSe = function () {
                    this.$state.go("admin.predmeti");
                };
                return VnesuvanjeController;
            }(app.base.ControllerBase));
            VnesuvanjeController.$inject = [
                app.InjectionIds.predmetService,
                "$scope",
                "$state",
                "$stateParams"
            ];
            predmeti.VnesuvanjeController = VnesuvanjeController;
            angular.module("app.admin")
                .controller(app.InjectionIds.admin_organizacii_vnesuvanjeController, VnesuvanjeController);
        })(predmeti = admin.predmeti || (admin.predmeti = {}));
    })(admin = app.admin || (app.admin = {}));
})(app || (app = {}));
