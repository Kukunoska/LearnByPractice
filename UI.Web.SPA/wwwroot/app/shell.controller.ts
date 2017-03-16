module app {
    "use strict";

    export class ShellController extends app.base.ControllerBase {

        public korisnik: app.model.security.Korisnik = new app.model.security.Korisnik();

        static $inject = [
            app.InjectionIds.korisnikService,
            "$scope"
        ];
        constructor(private korisnikService: app.services.security.IKorisnikService,
        private $scope: ng.IScope) {
            super();

            this.korisnikService.tekoven()
                .then((result: app.model.security.Korisnik): void => {
                    this.korisnik = result;
                    this.$scope.$apply();
                });
        }
    }

    angular.module("app")
        .controller(app.InjectionIds.shellController, ShellController);
}