module app {
    "use strict";

    export class ShellController extends app.base.ControllerBase {

        public korisnik: app.model.security.Korisnik = new app.model.security.Korisnik();

        static $inject = [
            app.InjectionIds.korisnikService,
            "$scope",
            "$state"
        ];
        constructor(private korisnikService: app.services.security.IKorisnikService,
            private $scope: ng.IScope, $state: ng.ui.IStateService) {
            super();

            this.korisnikService.tekoven()
                .then((result: app.model.security.Korisnik): void => {
                    this.korisnik = result;
                    this.$scope.$apply();
                    if (this.korisnik.administrator) {
                        $state.go("admin");
                    }
                    else if (this.korisnik.mentor) {
                        $state.go("mentor");
                    } else if (this.korisnik.student) {
                        $state.go("student");
                    }
                });
        }
    }

    angular.module("app")
        .controller(app.InjectionIds.shellController, ShellController);
}