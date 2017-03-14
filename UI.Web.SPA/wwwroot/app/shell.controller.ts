module app {
    "use strict";

    export class ShellController extends app.base.ControllerBase {

        public korisnik: app.model.security.Korisnik = new app.model.security.Korisnik();

        static $inject = [
            app.InjectionIds.korisniciService,
            "$scope"
        ];
        constructor(private korisniciService: app.services.security.IKorisniciService,
        private $scope: ng.IScope) {
            super();

            this.korisniciService.tekoven()
                .then((result: app.model.security.Korisnik): void => {
                    this.korisnik = result;
                    this.$scope.$apply();
                });
        }
    }

    angular.module("app")
        .controller(app.InjectionIds.shellController, ShellController);
}