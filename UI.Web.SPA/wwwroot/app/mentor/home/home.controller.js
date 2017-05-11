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
    var mentor;
    (function (mentor) {
        "use strict";
        var HomeController = (function (_super) {
            __extends(HomeController, _super);
            function HomeController() {
                return _super.call(this) || this;
            }
            return HomeController;
        }(app.base.ControllerBase));
        HomeController.$inject = [];
        mentor.HomeController = HomeController;
        angular.module("app.mentor")
            .controller(app.InjectionIds.mentor_homeController, HomeController);
    })(mentor = app.mentor || (app.mentor = {}));
})(app || (app = {}));
