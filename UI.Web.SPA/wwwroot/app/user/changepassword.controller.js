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
    var user;
    (function (user) {
        "use strict";
        var ChangePasswordController = (function (_super) {
            __extends(ChangePasswordController, _super);
            function ChangePasswordController() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            return ChangePasswordController;
        }(app.base.ControllerBase));
        user.ChangePasswordController = ChangePasswordController;
        angular.module("app.user")
            .controller(app.InjectionIds.user_changePasswordController, ChangePasswordController);
    })(user = app.user || (app.user = {}));
})(app || (app = {}));
