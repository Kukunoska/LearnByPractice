module app.admin {
    "use strict";

    export namespace korisnici {
        export class VnesuvanjeController extends base.ControllerBase {

            public korisnik: app.model.security.Korisnik = new app.model.security.Korisnik();
            public novZapis: boolean;
            public izmena: boolean;

            static $inject = [
                app.InjectionIds.korisnikService,
                "$scope",
                "$state",
                "$stateParams"
            ];

            constructor(private korisnikService: app.services.security.IKorisnikService,
                $scope: ng.IScope,
                private $state: ng.ui.IStateService,
                private $stateParams: ng.ui.IStateParamsService) {

                super();

                let vm: VnesuvanjeController = this;
                let korisnikId: number = 0;
                if (vm.$stateParams["id"] != null) {
                    korisnikId = parseInt(this.$stateParams["id"], 10);
                    if (korisnikId !== 0) {
                        vm.korisnikService.zemi(korisnikId)
                            .then((result: app.model.security.Korisnik): void => {
                                vm.korisnik = result;
                                $scope.$apply();
                            });
                    }
                }
                vm.novZapis = korisnikId === 0;
                vm.izmena = !vm.novZapis;
            }

            public zapishi(): void {
                if (this.novZapis) {
                    this.korisnikService.nov(this.korisnik)
                        .then((result: app.model.security.Korisnik): void => {
                            this.$state.go("admin.korisnici");
                        });
                } else {
                    this.korisnikService.izmeni(this.korisnik)
                        .then((result: app.model.security.Korisnik): void => {
                            this.$state.go("admin.korisnici");
                        });
                }
            }

            public otkazhiSe(): void {
                this.$state.go("admin.korisnici");
            }
        }
        angular.module("app.admin")
            .controller(app.InjectionIds.admin_korisnici_vnesuvanjeController, VnesuvanjeController);
    }
}