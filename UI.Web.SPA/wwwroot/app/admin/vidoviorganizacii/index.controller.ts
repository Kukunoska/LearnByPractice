module app.admin {
    "use strict";

    export namespace vidoviorganizacii {

        export class IndexController extends base.ControllerBase {
            public siteVidoviOrganizacii: app.model.organizational.VidOrganizacija[] = [];

            static $inject = [
                app.InjectionIds.vidOrganizacijaService,
                "$scope"
            ];

            constructor(private vidOrganizacijaService: app.services.organizational.IVidOrganizacijaService, private $scope: ng.IScope) {
                super();

                this.vchitajVidoviOrganizacii();
            }

            public izbrishi(vidOrganizacija: app.model.organizational.VidOrganizacija) {
                if (confirm("Бришење на видот на организација '" + vidOrganizacija.ime + "' ?")) {
                    this.vidOrganizacijaService.izbrishi(vidOrganizacija)
                        .then((result: app.model.organizational.VidOrganizacija): void => {
                            this.vchitajVidoviOrganizacii();
                        });
                }
            }

            private vchitajVidoviOrganizacii(): void {
                this.vidOrganizacijaService.site()
                    .then((result: app.model.organizational.VidOrganizacija[]): void => {
                        this.siteVidoviOrganizacii = result;
                        this.$scope.$apply();
                    });
            }
        }

        angular.module("app.admin")
            .controller(app.InjectionIds.admin_vidoviOrganizacii_indexController, IndexController);
    }
}