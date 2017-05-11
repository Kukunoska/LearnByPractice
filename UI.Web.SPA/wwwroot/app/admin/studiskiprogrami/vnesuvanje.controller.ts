module app.admin {
    "use strict";

    export namespace studiskiprogrami {

        export class VnesuvanjeController extends base.ControllerBase {
            public studiskaprograma: app.model.education.StudiskaPrograma = new app.model.education.StudiskaPrograma();
            public novZapis: boolean;
            public izmena: boolean;

            static $inject = [
                app.InjectionIds.studiskaProgramaService,
                "$scope",
                "$state",
                "$stateParams"
            ];

            constructor(private studiskaProgramaService: app.services.education.IStudiskaProgramaService,
                $scope: ng.IScope,
                private $state: ng.ui.IStateService,
                private $stateParams: ng.ui.IStateParamsService) {

                super();

                let vm: VnesuvanjeController = this;
                let studiskaprogramaid: number = 0;
                if (vm.$stateParams["id"] != null) {
                    studiskaprogramaid = parseInt(this.$stateParams["id"], 10);
                    if (studiskaprogramaid !== 0) {
                        vm.studiskaProgramaService.zemi(studiskaprogramaid)
                            .then((result: app.model.education.StudiskaPrograma): void => {
                                vm.studiskaprograma = result;
                                $scope.$apply();
                            });
                    }
                }

                vm.novZapis = studiskaprogramaid === 0;
                vm.izmena = !vm.novZapis;
                $scope.$apply();
            }

            public zapishi(): void {
                if (this.novZapis) {
                    this.studiskaProgramaService.nova(this.studiskaprograma)
                        .then((result: app.model.education.StudiskaPrograma): void => {
                            this.$state.go("admin.studiskaPrograma");
                        });
                } else {
                    this.studiskaProgramaService.izmeni(this.studiskaprograma)
                        .then((result: app.model.education.StudiskaPrograma): void => {
                            this.$state.go("admin.studiskaPrograma");
                        });
                }
            }

            public otkazhiSe(): void {
                this.$state.go("admin.studiskaPrograma");
            }
        }

        angular.module("app.admin")
            .controller(app.InjectionIds.admin_organizacii_vnesuvanjeController, VnesuvanjeController);
    }
}