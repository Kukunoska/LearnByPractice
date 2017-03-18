module app.admin {
    "use strict";

    export namespace predmeti {

        export class VnesuvanjeController extends base.ControllerBase {
            public predmet: app.model.education.Predmet = new app.model.education.Predmet();
            public novZapis: boolean;
            public izmena: boolean;

            static $inject = [
                app.InjectionIds.predmetService,
                "$scope",
                "$state",
                "$stateParams"
            ];

            constructor(private predmetService: app.services.education.IPredmetService,
                $scope: ng.IScope,
                private $state: ng.ui.IStateService,
                private $stateParams: ng.ui.IStateParamsService) {

                super();

                let vm: VnesuvanjeController = this;
                let predmetId: number = 0;
                if (vm.$stateParams["id"] != null) {
                    predmetId = parseInt(this.$stateParams["id"], 10);
                    if (predmetId !== 0) {
                        vm.predmetService.zemi(predmetId)
                            .then((result: app.model.education.Predmet): void => {
                                vm.predmet = result;
                                $scope.$apply();
                            });
                    }
                }

                vm.novZapis = predmetId === 0;
                vm.izmena = !vm.novZapis;
        }

            public zapishi(): void {
            if(this.novZapis) {
                this.predmetService.nov(this.predmet)
                    .then((result: app.model.education.Predmet): void => {
                        this.$state.go("admin.predmeti");
                    });
            } else {
                this.predmetService.izmeni(this.predmet)
                    .then((result: app.model.education.Predmet): void => {
                        this.$state.go("admin.predmeti");
                    });
            }
        }

            public otkazhiSe(): void {
            this.$state.go("admin.predmeti");
        }
    }

    angular.module("app.admin")
        .controller(app.InjectionIds.admin_kompanii_vnesuvanjeController, VnesuvanjeController);
}
}