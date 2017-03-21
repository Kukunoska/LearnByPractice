module app.user {
    "use strict";

    export class ChangePasswordController extends base.ControllerBase {
    }

    angular.module("app.user")
        .controller(app.InjectionIds.user_changePasswordController, ChangePasswordController);
}