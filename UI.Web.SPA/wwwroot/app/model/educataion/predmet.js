var app;
(function (app) {
    var model;
    (function (model) {
        "use strict";
        var education;
        (function (education) {
            var Predmet = (function () {
                function Predmet() {
                }
                return Predmet;
            }());
            education.Predmet = Predmet;
        })(education = model.education || (model.education = {}));
    })(model = app.model || (app.model = {}));
})(app || (app = {}));
//# sourceMappingURL=predmet.js.map