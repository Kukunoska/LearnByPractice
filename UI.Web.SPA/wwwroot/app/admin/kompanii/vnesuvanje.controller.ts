module app.admin {
    "use strict";

    export namespace kompanii {

        export class VnesuvanjeController extends base.ControllerBase {
            public kompanija: app.model.organizational.Kompanija = new app.model.organizational.Kompanija();
            public siteVidoviOrganizacii: app.model.organizational.VidOrganizacija[] = [];
            public novZapis: boolean;
            public izmena: boolean;

            static $inject = [
                app.InjectionIds.kompanijaService,
                app.InjectionIds.vidOrganizacijaService,
                "$scope",
                "$state",
                "$stateParams"
            ];

            constructor(private kompanijaService: app.services.organizational.IKompanijaService,
                vidOrganizacijaService: app.services.organizational.IVidOrganizacijaService,
                $scope: ng.IScope,
                private $state: ng.ui.IStateService,
                private $stateParams: ng.ui.IStateParamsService) {

                super();

                let vm: VnesuvanjeController = this;
                vidOrganizacijaService.site()
                    .then((result: app.model.organizational.VidOrganizacija[]): void => {
                        vm.siteVidoviOrganizacii = result;

                        let kompanijaId: number = 0;
                        if (vm.$stateParams["id"] != null) {
                            kompanijaId = parseInt(this.$stateParams["id"], 10);
                            if (kompanijaId !== 0) {
                                vm.kompanijaService.zemi(kompanijaId)
                                    .then((result: app.model.organizational.Kompanija): void => {
                                        vm.kompanija = result;
                                        console.log(vm.kompanija);
                                        $scope.$apply();
                                    });
                            }
                        }

                        if ((kompanijaId === 0) && (vm.siteVidoviOrganizacii.length > 0)) {
                            vm.kompanija.vidOrganizacija.id = vm.siteVidoviOrganizacii[0].id;
                        }

                        vm.novZapis = kompanijaId === 0;
                        vm.izmena = !vm.novZapis;

                        $scope.$apply();
                    });
            }

            public zapishi(): void {
                if (this.novZapis) {
                    this.kompanijaService.nova(this.kompanija)
                        .then((result: app.model.organizational.Kompanija): void => {
                            this.$state.go("admin.kompanii");
                        });
                } else {
                    this.kompanijaService.izmeni(this.kompanija)
                        .then((result: app.model.organizational.Kompanija): void => {
                            this.$state.go("admin.kompanii");
                        });
                }
            }

            public otkazhiSe(): void {
                this.$state.go("admin.kompanii");
            }
        }

        angular.module("app.admin")
            .controller(app.InjectionIds.admin_kompanii_vnesuvanjeController, VnesuvanjeController);
    }
}