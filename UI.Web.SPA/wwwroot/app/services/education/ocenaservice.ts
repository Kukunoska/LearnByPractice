module app.services {
    "use strict";

    export namespace education {
        export class OcenaService extends base.ServiceBase implements IOcenaService {

            constructor() {
                super();
            }

            public site(): ng.IPromise<app.model.education.Ocena[]> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.get("app/education/ocena/site", config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.education.Ocena[]>): app.model.education.Ocena[] => {
                        return response.data;
                    });
            }

            public zemi(id: number): ng.IPromise<app.model.education.Ocena> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();
                config.params.id = id;

                return this.$http.get("app/education/ocena/zemi", config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.education.Ocena>): app.model.education.Ocena => {
                        return response.data;
                    });
            }

            public nov(novaOcena: app.model.education.Ocena): ng.IPromise<app.model.education.Ocena> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("app/education/ocena/nov", novaOcena, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.education.Ocena>): app.model.education.Ocena => {
                        return response.data;
                    });
            }

            public izmeni(ocena: app.model.education.Ocena): ng.IPromise<app.model.education.Ocena> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("app/education/ocena/izmeni", ocena, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.education.Ocena>): app.model.education.Ocena => {
                        return response.data;
                    });
            }

            public izbrishi(ocena: app.model.education.Ocena): ng.IPromise<app.model.education.Ocena> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("app/education/ocena/izbrishi", ocena, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.education.Ocena>): app.model.education.Ocena => {
                        return response.data;
                    });
            }
        }
        angular
            .module("app.services")
            .service(app.InjectionIds.ocenaService, OcenaService);
    }
}