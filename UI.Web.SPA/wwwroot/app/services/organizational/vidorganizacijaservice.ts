module app.services {
    "use strict";

    export namespace organizational {
        export class VidOrganizacijaService extends base.ServiceBase implements IVidOrganizacijaService {

            constructor() {
                super();
            }

            public site(): ng.IPromise<app.model.organizational.VidOrganizacija[]> {

                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.get("api/organizational/vidorganizacija/site", config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.organizational.VidOrganizacija[]>): app.model.organizational.VidOrganizacija[] => {
                        return response.data;
                    });
            }

            public zemi(id: number): ng.IPromise<app.model.organizational.VidOrganizacija> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();
                config.params.id = id;

                return this.$http.get("api/organizational/vidorganizacija/zemi", config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.organizational.VidOrganizacija>): app.model.organizational.VidOrganizacija => {
                        return response.data;
                    });
            }

            public nov(vidOrganizacija: app.model.organizational.VidOrganizacija): ng.IPromise<app.model.organizational.VidOrganizacija> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/organizational/vidorganizacija/nov", vidOrganizacija, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.organizational.VidOrganizacija>): app.model.organizational.VidOrganizacija => {
                        return response.data;
                    });
            }

            public izmeni(vidOrganizacija: app.model.organizational.VidOrganizacija): ng.IPromise<app.model.organizational.VidOrganizacija> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/organizational/vidorganizacija/izmeni", vidOrganizacija, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.organizational.VidOrganizacija>): app.model.organizational.VidOrganizacija => {
                        return response.data;
                    });
            }

            public izbrishi(vidOrganizacija: app.model.organizational.VidOrganizacija): ng.IPromise<app.model.organizational.VidOrganizacija> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/organizational/vidorganizacija/izbrishi", vidOrganizacija, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.organizational.VidOrganizacija>): app.model.organizational.VidOrganizacija => {
                        return response.data;
                    });
            }

        }

        angular
            .module("app.services")
            .service(app.InjectionIds.vidOrganizacijaService, VidOrganizacijaService);
    }
}