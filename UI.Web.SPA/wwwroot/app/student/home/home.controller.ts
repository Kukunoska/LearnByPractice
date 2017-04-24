module app.student {
    "use strict";

    export class HomeController extends base.ControllerBase {

        static $inject = [
        ];

        constructor() {
            super();
        }
    }

    angular.module("app.student")
        .controller(app.InjectionIds.student_homeController, HomeController);
}