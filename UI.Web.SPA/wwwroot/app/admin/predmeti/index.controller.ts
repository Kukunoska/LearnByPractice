module app.admin {
    "use strict";

    export namespace predmeti {

        export class IndexController extends base.ControllerBase {
            public sitePredmeti: app.model.education.Predmet[] = [];

            static $inject = [
                app.InjectionIds.predmetiService,
                "$scope"
            ];

            constructor(private predmetiService: app.services.education.IPredmetiService, $scope: ng.IScope) {
                super();

                this.predmetiService.site()
                    .then((result: app.model.education.Predmet[]): void => {
                        this.sitePredmeti = result;
                        $scope.$apply();
                    });
            }
        }

        angular.module("app.admin")
            .controller(app.InjectionIds.admin_predmeti_indexController, IndexController);
    }
}