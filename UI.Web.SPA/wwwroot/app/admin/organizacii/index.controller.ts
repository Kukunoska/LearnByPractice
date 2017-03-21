module app.admin {
    "use strict";

    export namespace organizacii {

        export class IndexController extends base.ControllerBase {
            public siteOrganizacii: app.model.organizational.Organizacija[] = [];

            static $inject = [
                app.InjectionIds.organizacijaService,
                "$scope"
            ];

            constructor(private organizacijaService: app.services.organizational.IOrganizacijaService, private $scope: ng.IScope) {
                super();

                this.vchitajOrganizacii();
            }

            public izbrishi(organizacija: app.model.organizational.Organizacija) {
                if (confirm("Бришење на организацијата '" + organizacija.ime + "' ?")) {
                    this.organizacijaService.izbrishi(organizacija)
                        .then((result: app.model.organizational.Organizacija): void => {
                            this.vchitajOrganizacii();
                        });
                }
            }

            private vchitajOrganizacii(): void {
                this.organizacijaService.site()
                    .then((result: app.model.organizational.Organizacija[]): void => {
                        this.siteOrganizacii = result;
                        this.$scope.$apply();
                    });
            }
        }

        angular.module("app.admin")
            .controller(app.InjectionIds.admin_organizacii_indexController, IndexController);
    }
}