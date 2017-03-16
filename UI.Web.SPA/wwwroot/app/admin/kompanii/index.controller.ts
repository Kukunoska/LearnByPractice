module app.admin {
    "use strict";

    export namespace kompanii {

        export class IndexController extends base.ControllerBase {
            public siteKompanii: app.model.organizational.Kompanija[] = [];

            static $inject = [
                app.InjectionIds.kompanijaService,
                "$scope"
            ];

            constructor(private kompanijaService: app.services.organizational.IKompanijaService, private $scope: ng.IScope) {
                super();

                this.vchitajKompanii();
            }

            public izbrishi(kompanija: app.model.organizational.Kompanija) {
                if (confirm("Бришење на компанијата '" + kompanija.ime + "' ?")) {
                    this.kompanijaService.izbrishi(kompanija)
                        .then((result: app.model.organizational.Kompanija): void => {
                            this.vchitajKompanii();
                        });
                }
            }

            private vchitajKompanii(): void {
                this.kompanijaService.site()
                    .then((result: app.model.organizational.Kompanija[]): void => {
                        this.siteKompanii = result;
                        this.$scope.$apply();
                    });
            }
        }

        angular.module("app.admin")
            .controller(app.InjectionIds.admin_kompanii_indexController, IndexController);
    }
}