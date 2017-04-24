module app.mentor {
    "use strict";

    export class HomeController extends base.ControllerBase {

        static $inject = [
        ];

        constructor() {
            super();
        }
    }

    angular.module("app.mentor")
        .controller(app.InjectionIds.mentor_homeController, HomeController);
}