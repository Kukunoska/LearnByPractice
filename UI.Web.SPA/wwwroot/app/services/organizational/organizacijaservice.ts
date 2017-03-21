module app.services {
    "use strict";

    export namespace organizational {
        export class OrganizacijaService extends base.ServiceBase implements IOrganizacijaService {

            constructor() {
                super();
            }

            public site(): ng.IPromise<app.model.organizational.Organizacija[]> {

                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.get("api/organizational/organizacija/site", config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.organizational.Organizacija[]>): app.model.organizational.Organizacija[] => {
                        return response.data;
                    });
            }

            public zemi(id: number): ng.IPromise<app.model.organizational.Organizacija> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();
                config.params.id = id;

                return this.$http.get("api/organizational/organizacija/zemi", config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.organizational.Organizacija>): app.model.organizational.Organizacija => {
                        return response.data;
                    });
            }

            public nova(organizacija: app.model.organizational.Organizacija): ng.IPromise<app.model.organizational.Organizacija> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/organizational/organizacija/nova", organizacija, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.organizational.Organizacija>): app.model.organizational.Organizacija => {
                        return response.data;
                    });
            }

            public izmeni(organizacija: app.model.organizational.Organizacija): ng.IPromise<app.model.organizational.Organizacija> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/organizational/organizacija/izmeni", organizacija, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.organizational.Organizacija>): app.model.organizational.Organizacija => {
                        return response.data;
                    });
            }

            public izbrishi(organizacija: app.model.organizational.Organizacija): ng.IPromise<app.model.organizational.Organizacija> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/organizational/organizacija/izbrishi", organizacija, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.organizational.Organizacija>): app.model.organizational.Organizacija => {
                        return response.data;
                    });
            }
        }

        angular
            .module("app.services")
            .service(app.InjectionIds.organizacijaService, OrganizacijaService);
    }
}