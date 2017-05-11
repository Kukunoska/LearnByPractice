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
            var IndexController = (function (_super) {
                __extends(IndexController, _super);
                function IndexController(vidOrganizacijaService, $scope) {
                    var _this = _super.call(this) || this;
                    _this.vidOrganizacijaService = vidOrganizacijaService;
                    _this.$scope = $scope;
                    _this.siteVidoviOrganizacii = [];
                    _this.vchitajVidoviOrganizacii();
                    return _this;
                }
                IndexController.prototype.izbrishi = function (vidOrganizacija) {
                    var _this = this;
                    if (confirm("Бришење на видот на организација '" + vidOrganizacija.ime + "' ?")) {
                        this.vidOrganizacijaService.izbrishi(vidOrganizacija)
                            .then(function (result) {
                            _this.vchitajVidoviOrganizacii();
                        });
                    }
                };
                IndexController.prototype.vchitajVidoviOrganizacii = function () {
                    var _this = this;
                    this.vidOrganizacijaService.site()
                        .then(function (result) {
                        _this.siteVidoviOrganizacii = result;
                        _this.$scope.$apply();
                    });
                };
                return IndexController;
            }(app.base.ControllerBase));
            IndexController.$inject = [
                app.InjectionIds.vidOrganizacijaService,
                "$scope"
            ];
            vidoviorganizacii.IndexController = IndexController;
            angular.module("app.admin")
                .controller(app.InjectionIds.admin_vidoviOrganizacii_indexController, IndexController);
        })(vidoviorganizacii = admin.vidoviorganizacii || (admin.vidoviorganizacii = {}));
    })(admin = app.admin || (app.admin = {}));
})(app || (app = {}));
