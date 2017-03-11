var app;
(function (app) {
    "use strict";
    var InjectionIds = (function () {
        function InjectionIds() {
        }
        Object.defineProperty(InjectionIds, "predmetiService", {
            get: function () {
                return "app.services.predmetiService";
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(InjectionIds, "indexController", {
            get: function () {
                return "app.indexController";
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(InjectionIds, "admin_predmeti_indexController", {
            get: function () {
                return "app.admin.predmeti.indexController";
            },
            enumerable: true,
            configurable: true
        });
        return InjectionIds;
    }());
    app.InjectionIds = InjectionIds;
})(app || (app = {}));
//# sourceMappingURL=injectionids.js.map