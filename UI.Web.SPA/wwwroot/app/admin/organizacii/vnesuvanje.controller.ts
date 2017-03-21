module app.admin {
    "use strict";

    export namespace organizacii {

        export class VnesuvanjeController extends base.ControllerBase {
            public organizacija: app.model.organizational.Organizacija = new app.model.organizational.Organizacija();
            public siteVidoviOrganizacii: app.model.organizational.VidOrganizacija[] = [];
            public novZapis: boolean;
            public izmena: boolean;

            static $inject = [
                app.InjectionIds.organizacijaService,
                app.InjectionIds.vidOrganizacijaService,
                "$scope",
                "$state",
                "$stateParams"
            ];

            constructor(private organizacijaService: app.services.organizational.IOrganizacijaService,
                vidOrganizacijaService: app.services.organizational.IVidOrganizacijaService,
                $scope: ng.IScope,
                private $state: ng.ui.IStateService,
                private $stateParams: ng.ui.IStateParamsService) {

                super();

                let vm: VnesuvanjeController = this;
                vidOrganizacijaService.site()
                    .then((result: app.model.organizational.VidOrganizacija[]): void => {
                        vm.siteVidoviOrganizacii = result;

                        let organizacijaId: number = 0;
                        if (vm.$stateParams["id"] != null) {
                            organizacijaId = parseInt(this.$stateParams["id"], 10);
                            if (organizacijaId !== 0) {
                                vm.organizacijaService.zemi(organizacijaId)
                                    .then((result: app.model.organizational.Organizacija): void => {
                                        vm.organizacija = result;
                                        $scope.$apply();
                                    });
                            }
                        }

                        if ((organizacijaId === 0) && (vm.siteVidoviOrganizacii.length > 0)) {
                            vm.organizacija.vidOrganizacija.id = vm.siteVidoviOrganizacii[0].id;
                        }

                        vm.novZapis = organizacijaId === 0;
                        vm.izmena = !vm.novZapis;

                        $scope.$apply();
                    });
            }

            public zapishi(): void {
                if (this.novZapis) {
                    this.organizacijaService.nova(this.organizacija)
                        .then((result: app.model.organizational.Organizacija): void => {
                            this.$state.go("admin.organizacii");
                        });
                } else {
                    this.organizacijaService.izmeni(this.organizacija)
                        .then((result: app.model.organizational.Organizacija): void => {
                            this.$state.go("admin.organizacii");
                        });
                }
            }

            public otkazhiSe(): void {
                this.$state.go("admin.organizacii");
            }
        }

        angular.module("app.admin")
            .controller(app.InjectionIds.admin_organizacii_vnesuvanjeController, VnesuvanjeController);
    }
}