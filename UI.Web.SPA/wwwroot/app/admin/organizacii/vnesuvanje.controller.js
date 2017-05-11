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
            var VnesuvanjeController = (function (_super) {
                __extends(VnesuvanjeController, _super);
                function VnesuvanjeController(organizacijaService, vidOrganizacijaService, $scope, $state, $stateParams) {
                    var _this = _super.call(this) || this;
                    _this.organizacijaService = organizacijaService;
                    _this.$state = $state;
                    _this.$stateParams = $stateParams;
                    _this.organizacija = new app.model.organizational.Organizacija();
                    _this.siteVidoviOrganizacii = [];
                    var vm = _this;
                    vidOrganizacijaService.site()
                        .then(function (result) {
                        vm.siteVidoviOrganizacii = result;
                        var organizacijaId = 0;
                        if (vm.$stateParams["id"] != null) {
                            organizacijaId = parseInt(_this.$stateParams["id"], 10);
                            if (organizacijaId !== 0) {
                                vm.organizacijaService.zemi(organizacijaId)
                                    .then(function (result) {
                                    vm.organizacija = result;
                                    $scope.$apply();
                                });
                            }
                        }
                        if ((organizacijaId === 0) && (vm.siteVidoviOrganizacii.length > 0)) {
                            vm.organizacija.vidOrganizacija.id = vm.siteVidoviOrganizacii[0].id;
                        }
                        vm.novZapis = organizacijaId === 0;
                        vm.izmena = !vm.novZapis;
                        $scope.$apply();
                    });
                    return _this;
                }
                VnesuvanjeController.prototype.zapishi = function () {
                    var _this = this;
                    if (this.novZapis) {
                        this.organizacijaService.nova(this.organizacija)
                            .then(function (result) {
                            _this.$state.go("admin.organizacii");
                        });
                    }
                    else {
                        this.organizacijaService.izmeni(this.organizacija)
                            .then(function (result) {
                            _this.$state.go("admin.organizacii");
                        });
                    }
                };
                VnesuvanjeController.prototype.otkazhiSe = function () {
                    this.$state.go("admin.organizacii");
                };
                return VnesuvanjeController;
            }(app.base.ControllerBase));
            VnesuvanjeController.$inject = [
                app.InjectionIds.organizacijaService,
                app.InjectionIds.vidOrganizacijaService,
                "$scope",
                "$state",
                "$stateParams"
            ];
            organizacii.VnesuvanjeController = VnesuvanjeController;
            angular.module("app.admin")
                .controller(app.InjectionIds.admin_organizacii_vnesuvanjeController, VnesuvanjeController);
        })(organizacii = admin.organizacii || (admin.organizacii = {}));
    })(admin = app.admin || (app.admin = {}));
})(app || (app = {}));
