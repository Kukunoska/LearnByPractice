module app.admin {
    "use strict";

    export namespace oblasti {

        export class IndexController extends base.ControllerBase {
            public siteOblasti: app.model.practice.Oblast[] = [];

            static $inject = [
                app.InjectionIds.oblastService,
                "$scope"
            ];

            constructor(private oblastService: app.services.practice.IOblastService, private $scope: ng.IScope) {
                super();

                this.vcitajOblast();
            }

            public izbrishi(oblast: app.model.practice.Oblast) {
                if (confirm("Бришење на област '" + oblast.ime + "' ?")) {
                    this.oblastService.izbrishi(oblast)
                        .then((result: app.model.practice.Oblast): void => {
                            this.vcitajOblast();
                        });
                }
            }

            private vcitajOblast(): void {
                this.oblastService.site()
                    .then((result: app.model.practice.Oblast[]): void => {
                        this.siteOblasti = result;
                        this.$scope.$apply();
                    });
            }
        }

        angular.module("app.admin")
            .controller(app.InjectionIds.admin_oblasti_indexController, IndexController);
    }
}