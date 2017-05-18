module app.admin {
    "use strict";

    export namespace tehnologii {
        export class VnesuvanjeController extends base.ControllerBase {

            public tehnologija: app.model.practice.Tehnologija = new app.model.practice.Tehnologija();
            public novZapis: boolean;
            public izmena: boolean;

            static $inject = [
                app.InjectionIds.tehnologijaService,
                "$scope",
                "$state",
                "$stateParams"
            ];

            constructor(private tehnologijaService: app.services.practice.ITehnologijaService,
                $scope: ng.IScope,
                private $state: ng.ui.IStateService,
                private $stateParams: ng.ui.IStateParamsService) {

                super();

                let vm: VnesuvanjeController = this;
                let tehnologijaId: number = 0;
                if (vm.$stateParams["id"] != null) {
                    tehnologijaId = parseInt(this.$stateParams["id"], 10);
                    if (tehnologijaId !== 0) {
                        vm.tehnologijaService.zemi(tehnologijaId)
                            .then((result: app.model.practice.Tehnologija): void => {
                                vm.tehnologija = result;
                                $scope.$apply();
                            });
                    }
                }
                vm.novZapis = tehnologijaId === 0;
                vm.izmena = !vm.novZapis;
            }

            public zapishi(): void {
                if (this.novZapis) {
                    this.tehnologijaService.nov(this.tehnologija)
                        .then((result: app.model.practice.Tehnologija): void => {
                            this.$state.go("admin.tehnologii");
                        });
                } else {
                    this.tehnologijaService.izmeni(this.tehnologija)
                        .then((result: app.model.practice.Tehnologija): void => {
                            this.$state.go("admin.tehnologii");
                        });
                }
            }
            public otkazhiSe(): void {
                this.$state.go("admin.tehnologii");
            }
        }
        angular.module("app.admin")
            .controller(app.InjectionIds.admin_tehnologii_vnesuvanjeController, VnesuvanjeController);
    }
}