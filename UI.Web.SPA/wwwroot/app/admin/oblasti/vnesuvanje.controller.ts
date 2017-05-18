module app.admin {
    "use strict";

    export namespace oblasti {
        export class VnesuvanjeController extends base.ControllerBase {

            public oblast: app.model.practice.Oblast = new app.model.practice.Oblast();
            public novZapis: boolean;
            public izmena: boolean;

            static $inject = [
                app.InjectionIds.oblastService,
                "$scope",
                "$state",
                "$stateParams"
            ];

            constructor(private oblastService: app.services.practice.IOblastService,
                $scope: ng.IScope,
                private $state: ng.ui.IStateService,
                private $stateParams: ng.ui.IStateParamsService) {

                super();

                let vm: VnesuvanjeController = this;
                let oblastId: number = 0;
                if (vm.$stateParams["id"] != null) {
                    oblastId = parseInt(this.$stateParams["id"], 10);
                    if (oblastId !== 0) {
                        vm.oblastService.zemi(oblastId)
                            .then((result: app.model.practice.Oblast): void => {
                                vm.oblast = result;
                                $scope.$apply();
                            });
                    }
                }
                vm.novZapis = oblastId === 0;
                vm.izmena = !vm.novZapis;
            }

            public zapishi(): void {
                if (this.novZapis) {
                    this.oblastService.nov(this.oblast)
                        .then((result: app.model.practice.Oblast): void => {
                            this.$state.go("admin.oblasti");
                        });
                } else {
                    this.oblastService.izmeni(this.oblast)
                        .then((result: app.model.practice.Oblast): void => {
                            this.$state.go("admin.oblasti");
                        });
                }
            }

            public otkazhiSe(): void {
                this.$state.go("admin.oblasti");
            }
        }
        angular.module("app.admin")
            .controller(app.InjectionIds.admin_oblasti_vnesuvanjeController, VnesuvanjeController);
    }
}