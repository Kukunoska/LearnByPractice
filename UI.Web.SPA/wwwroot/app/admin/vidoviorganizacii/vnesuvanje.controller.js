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
        var vidoviorganizacii;
        (function (vidoviorganizacii) {
            var VnesuvanjeController = (function (_super) {
                __extends(VnesuvanjeController, _super);
                function VnesuvanjeController(vidOrganizacijaService, $scope, $state, $stateParams) {
                    var _this = _super.call(this) || this;
                    _this.vidOrganizacijaService = vidOrganizacijaService;
                    _this.$state = $state;
                    _this.$stateParams = $stateParams;
                    _this.vidOrganizacija = new app.model.organizational.VidOrganizacija();
                    var vm = _this;
                    var vidOrganizacijaId = 0;
                    if (vm.$stateParams["id"] != null) {
                        vidOrganizacijaId = parseInt(_this.$stateParams["id"], 10);
                        if (vidOrganizacijaId !== 0) {
                            vm.vidOrganizacijaService.zemi(vidOrganizacijaId)
                                .then(function (result) {
                                vm.vidOrganizacija = result;
                                $scope.$apply();
                            });
                        }
                    }
                    vm.novZapis = vidOrganizacijaId === 0;
                    vm.izmena = !vm.novZapis;
                    $scope.$apply();
                    return _this;
                }
                VnesuvanjeController.prototype.zapishi = function () {
                    var _this = this;
                    if (this.novZapis) {
                        this.vidOrganizacijaService.nov(this.vidOrganizacija)
                            .then(function (result) {
                            _this.$state.go("admin.vidoviorganizacii");
                        });
                    }
                    else {
                        this.vidOrganizacijaService.izmeni(this.vidOrganizacija)
                            .then(function (result) {
                            _this.$state.go("admin.vidoviorganizacii");
                        });
                    }
                };
                VnesuvanjeController.prototype.otkazhiSe = function () {
                    this.$state.go("admin.vidoviorganizacii");
                };
                return VnesuvanjeController;
            }(app.base.ControllerBase));
            VnesuvanjeController.$inject = [
                app.InjectionIds.vidOrganizacijaService,
                "$scope",
                "$state",
                "$stateParams"
            ];
            vidoviorganizacii.VnesuvanjeController = VnesuvanjeController;
            angular.module("app.admin")
                .controller(app.InjectionIds.admin_vidoviOrganizacii_vnesuvanjeController, VnesuvanjeController);
        })(vidoviorganizacii = admin.vidoviorganizacii || (admin.vidoviorganizacii = {}));
    })(admin = app.admin || (app.admin = {}));
})(app || (app = {}));
