module app.admin {
    "use strict";

    export namespace tehnologii {
        export class IndexController extends base.ControllerBase {

            public siteTehnologii: app.model.practice.Tehnologija[] = [];

            static $inject = [
                app.InjectionIds.tehnologijaService,
                "$scope"
            ];

            constructor(private tehnologijaService: app.services.practice.ITehnologijaService, $scope: ng.IScope) {
                super();

                this.tehnologijaService.site()
                    .then((result: app.model.practice.Tehnologija[]): void => {
                        this.siteTehnologii = result;
                        $scope.$apply();
                    });
            }
        }
        angular.module("app.admin")
            .controller(app.InjectionIds.admin_tehnologii_indexController, IndexController);
    }
}