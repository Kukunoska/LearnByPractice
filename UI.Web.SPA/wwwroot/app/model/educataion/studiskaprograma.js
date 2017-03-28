var app;
(function (app) {
    var model;
    (function (model) {
        "use strict";
        var education;
        (function (education) {
            var StudiskaPrograma = (function () {
                function StudiskaPrograma() {
                }
                return StudiskaPrograma;
            }());
            education.StudiskaPrograma = StudiskaPrograma;
        })(education = model.education || (model.education = {}));
    })(model = app.model || (app.model = {}));
})(app || (app = {}));
