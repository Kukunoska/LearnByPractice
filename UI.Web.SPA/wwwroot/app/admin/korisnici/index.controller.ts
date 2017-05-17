module app.admin {
    "use strict";

    export namespace korisnici {

        export class IndexController extends base.ControllerBase {
            public siteKorisnici: app.model.security.Korisnik[] = [];

            static $inject = [
                app.InjectionIds.korisnikService,
                "$scope"
            ];

            constructor(private korisnikService: app.services.security.IKorisnikService, private $scope: ng.IScope) {
                super();

                this.vcitajKorisnik();
            }

            public izbrishi(korisnik: app.model.security.Korisnik) {
                if (confirm("Бришење на корисник '" + korisnik.ime + "' ?")) {
                    this.korisnikService.izbrishi(korisnik)
                        .then((result: app.model.security.Korisnik): void => {
                            this.vcitajKorisnik();
                        });
                }
            }

            private vcitajKorisnik(): void {
                this.korisnikService.site()
                    .then((result: app.model.security.Korisnik[]): void => {
                        this.siteKorisnici = result;
                        this.$scope.$apply();
                    });
            }
        }

        angular.module("app.admin")
            .controller(app.InjectionIds.admin_korisnici_indexController, IndexController);
    }
}