module app.user {
    "use strict";

    export class EditProfileController extends base.ControllerBase {
    }

    angular.module("app.user")
        .controller(app.InjectionIds.user_editProfileController, EditProfileController);
}