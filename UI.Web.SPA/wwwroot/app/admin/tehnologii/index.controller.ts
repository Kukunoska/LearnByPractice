module app.admin {
    "use strict";

    export namespace tehnologii {
        export class IndexController extends base.ControllerBase {

            public siteTehnologii: app.model.practice.Tehnologija[] = [];

            static $inject = [
                app.InjectionIds.tehnologijaService,
                "$scope"
            ];

            constructor(private tehnologijaService: app.services.practice.ITehnologijaService, private $scope: ng.IScope) {
                super();

                this.vcitajTehnologija();
                
            }

            public izbrishi(tehnologija: app.model.practice.Tehnologija) {
                if (confirm("Бришење на технологија '" + tehnologija.ime + "' ?")) {
                    this.tehnologijaService.izbrishi(tehnologija)
                        .then((result: app.model.practice.Tehnologija): void => {
                            this.vcitajTehnologija();
                        });
                }
            }

            private vcitajTehnologija(): void {
                this.tehnologijaService.site()
                    .then((result: app.model.practice.Tehnologija[]): void => {
                        this.siteTehnologii = result;
                        this.$scope.$apply();
                    });
            }
        }
        angular.module("app.admin")
            .controller(app.InjectionIds.admin_tehnologii_indexController, IndexController);
    }
}