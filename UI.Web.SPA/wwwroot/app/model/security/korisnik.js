var app;
(function (app) {
    var model;
    (function (model) {
        "use strict";
        var security;
        (function (security) {
            var Korisnik = (function () {
                function Korisnik() {
                }
                return Korisnik;
            }());
            security.Korisnik = Korisnik;
        })(security = model.security || (model.security = {}));
    })(model = app.model || (app.model = {}));
})(app || (app = {}));
