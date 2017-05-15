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
        var oblasti;
        (function (oblasti) {
            var IndexController = (function (_super) {
                __extends(IndexController, _super);
                function IndexController() {
                    return _super !== null && _super.apply(this, arguments) || this;
                }
                return IndexController;
            }(app.base.ControllerBase));
            oblasti.IndexController = IndexController;
        })(oblasti = admin.oblasti || (admin.oblasti = {}));
    })(admin = app.admin || (app.admin = {}));
})(app || (app = {}));
