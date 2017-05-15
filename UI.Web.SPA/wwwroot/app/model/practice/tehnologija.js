var app;
(function (app) {
    var model;
    (function (model) {
        "use strict";
        var practice;
        (function (practice) {
            var Tehnologija = (function () {
                function Tehnologija() {
                    this.oblastId = new practice.Oblast();
                }
                return Tehnologija;
            }());
            practice.Tehnologija = Tehnologija;
        })(practice = model.practice || (model.practice = {}));
    })(model = app.model || (app.model = {}));
})(app || (app = {}));
