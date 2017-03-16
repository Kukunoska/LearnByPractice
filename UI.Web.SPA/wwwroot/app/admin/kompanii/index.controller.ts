module app.admin {
    "use strict";

    export namespace kompanii {

        export class IndexController extends base.ControllerBase {
            public siteKompanii: app.model.organizational.Kompanija[] = [];

            static $inject = [
                app.InjectionIds.kompanijaService,
                "$scope"
            ];

            constructor(private kompanijaService: app.services.organizational.IKompanijaService, $scope: ng.IScope) {
                super();

                this.kompanijaService.site()
                    .then((result: app.model.organizational.Kompanija[]): void => {
                        this.siteKompanii = result;
                        $scope.$apply();
                    });
            }
        }

        angular.module("app.admin")
            .controller(app.InjectionIds.admin_kompanii_indexController, IndexController);
    }
}