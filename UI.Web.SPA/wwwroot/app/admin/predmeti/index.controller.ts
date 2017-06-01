module app.admin {
    "use strict";

    export namespace predmeti {

        export class IndexController extends base.ControllerBase {
            public sitePredmeti: app.model.education.Predmet[] = [];

            static $inject = [
                app.InjectionIds.predmetService,
                "$scope"
            ];

            constructor(private predmetService: app.services.education.IPredmetService, private $scope: ng.IScope) {
                super();

                this.vcitajPredmeti();
            }

            public izbrishi(predmet: app.model.education.Predmet): void {
                if (confirm("Бришење на предмет '" + predmet.ime + "' ?")) {
                    this.predmetService.izbrishi(predmet)
                        .then((result: app.model.education.Predmet): void => {
                            this.vcitajPredmeti();
                        });
                }
            }

            private vcitajPredmeti(): void {
                this.predmetService.site()
                    .then((result: app.model.education.Predmet[]): void => {
                        this.sitePredmeti = result;
                        this.$scope.$apply();
                    });
            }
        }

        angular.module("app.admin")
            .controller(app.InjectionIds.admin_predmeti_indexController, IndexController);
    }
}