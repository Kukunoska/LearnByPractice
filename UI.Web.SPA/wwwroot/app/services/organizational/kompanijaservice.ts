module app.services {
    "use strict";

    export namespace organizational {
        export class KompanijaService extends base.ServiceBase implements IKompanijaService {

            constructor() {
                super();
            }

            public site(): ng.IPromise<app.model.organizational.Kompanija[]> {

                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.get("api/organizational/kompanija/site", config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.organizational.Kompanija[]>): app.model.organizational.Kompanija[] => {
                        return response.data;
                    });
            }

            public zemi(id: number): ng.IPromise<app.model.organizational.Kompanija> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();
                config.params.id = id;

                return this.$http.get("api/organizational/kompanija/zemi", config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.organizational.Kompanija>): app.model.organizational.Kompanija => {
                        return response.data;
                    });
            }

            public nova(novaKompanija: app.model.organizational.Kompanija): ng.IPromise<app.model.organizational.Kompanija> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/organizational/kompanija/nova", novaKompanija, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.organizational.Kompanija>): app.model.organizational.Kompanija => {
                        return response.data;
                    });
            }

            public izmeni(kompanija: app.model.organizational.Kompanija): ng.IPromise<app.model.organizational.Kompanija> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/organizational/kompanija/izmeni", kompanija, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.organizational.Kompanija>): app.model.organizational.Kompanija => {
                        return response.data;
                    });
            }

            public izbrishi(kompanija: app.model.organizational.Kompanija): ng.IPromise<app.model.organizational.Kompanija> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/organizational/kompanija/izbrishi", kompanija, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.organizational.Kompanija>): app.model.organizational.Kompanija => {
                        return response.data;
                    });
            }
        }

        angular
            .module("app.services")
            .service(app.InjectionIds.kompanijaService, KompanijaService);
    }
}