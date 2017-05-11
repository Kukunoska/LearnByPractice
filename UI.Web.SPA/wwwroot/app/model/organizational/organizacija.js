var app;
(function (app) {
    var model;
    (function (model) {
        "use strict";
        var organizational;
        (function (organizational) {
            var Organizacija = (function () {
                function Organizacija() {
                    this.vidOrganizacija = new organizational.VidOrganizacija();
                }
                return Organizacija;
            }());
            organizational.Organizacija = Organizacija;
        })(organizational = model.organizational || (model.organizational = {}));
    })(model = app.model || (app.model = {}));
})(app || (app = {}));
