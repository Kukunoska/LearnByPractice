module app {
    "use strict";

    export class IndexController extends base.ControllerBase {

        constructor() {
            super();
        }
    }

    angular.module("app")
        .controller(app.InjectionIds.indexController, IndexController);
}