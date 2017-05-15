var app;
(function (app) {
    var model;
    (function (model) {
        "use strict";
        var education;
        (function (education) {
            var Ocena = (function () {
                function Ocena() {
                    this.student = new model.security.Korisnik();
                    this.predmet = new education.Predmet();
                }
                return Ocena;
            }());
            education.Ocena = Ocena;
        })(education = model.education || (model.education = {}));
    })(model = app.model || (app.model = {}));
})(app || (app = {}));
