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
    "use strict";
    var ShellController = (function (_super) {
        __extends(ShellController, _super);
        function ShellController(korisnikService, $scope, $state) {
            var _this = _super.call(this) || this;
            _this.korisnikService = korisnikService;
            _this.$scope = $scope;
            _this.korisnik = new app.model.security.Korisnik();
            _this.korisnikService.tekoven()
                .then(function (result) {
                _this.korisnik = result;
                _this.$scope.$apply();
                if (_this.korisnik.administrator) {
                    $state.go("admin");
                }
                else if (_this.korisnik.mentor) {
                    $state.go("mentor");
                }
                else if (_this.korisnik.student) {
                    $state.go("student");
                }
            });
            return _this;
        }
        return ShellController;
    }(app.base.ControllerBase));
    ShellController.$inject = [
        app.InjectionIds.korisnikService,
        "$scope",
        "$state"
    ];
    app.ShellController = ShellController;
    angular.module("app")
        .controller(app.InjectionIds.shellController, ShellController);
})(app || (app = {}));
