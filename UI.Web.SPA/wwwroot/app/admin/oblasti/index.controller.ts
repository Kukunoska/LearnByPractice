module app.admin {
    "use strict";

    export namespace oblasti {
        export class IndexController extends base.ControllerBase {

            public siteOblasti: app.model.practice.Oblast[] = [];

            static $inject = [
                app.InjectionIds.oblastService,
                "$scope"
            ];

            constructor(private oblastService: app.services.practice.IOblastService, $scope: ng.IScope) {
                super();

                this.oblastService.site()
                    .then((result: app.model.practice.Oblast[]): void => {
                        this.siteOblasti = result;
                        $scope.$apply();
                    });
            }
        }
        angular.module("app.admin")
            .controller(app.InjectionIds.admin_oblasti_indexController, IndexController);
    }
}