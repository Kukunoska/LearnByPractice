module app.admin {
    "use strict";

    export namespace studiskiprogrami {

        export class IndexController extends base.ControllerBase {
            public siteStudiskiProgrami: app.model.education.StudiskaPrograma[] = [];

            static $inject = [
                app.InjectionIds.studiskaProgramaService,
                "$scope"
            ];

            constructor(private studiskaProgramaService: app.services.education.IStudiskaProgramaService, private $scope: ng.IScope) {
                super();

                this.vchitajStudiskaPrograma();
            }

            public izbrishi(studiskaprograma: app.model.education.StudiskaPrograma) {
                if (confirm("Бришење на студиска програма '" + studiskaprograma.ime + "' ?")) {
                    this.studiskaProgramaService.izbrishi(studiskaprograma)
                        .then((result: app.model.education.StudiskaPrograma): void => {
                            this.vchitajStudiskaPrograma();
                        });
                }
            }

            private vchitajStudiskaPrograma(): void {
                this.studiskaProgramaService.site()
                    .then((result: app.model.education.StudiskaPrograma[]): void => {
                        this.siteStudiskiProgrami = result;
                        this.$scope.$apply();
                    });
            }
        }

        angular.module("app.admin")
            .controller(app.InjectionIds.admin_studiskiProgrami_indexController, IndexController);
    }
}
