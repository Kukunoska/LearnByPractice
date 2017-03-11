var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var app;
(function (app) {
    "use strict";
    var IndexController = (function (_super) {
        __extends(IndexController, _super);
        function IndexController() {
            _super.call(this);
        }
        return IndexController;
    }(app.base.ControllerBase));
    app.IndexController = IndexController;
    angular.module("app")
        .controller(app.InjectionIds.indexController, IndexController);
})(app || (app = {}));
//# sourceMappingURL=index.controller.js.map