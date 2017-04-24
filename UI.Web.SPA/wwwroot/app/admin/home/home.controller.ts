module app.admin {
    "use strict";

    export class HomeController extends base.ControllerBase {

        static $inject = [
        ];

        constructor() {
            super();
        }
    }

    angular.module("app.admin")
        .controller(app.InjectionIds.admin_homeController, HomeController);
}