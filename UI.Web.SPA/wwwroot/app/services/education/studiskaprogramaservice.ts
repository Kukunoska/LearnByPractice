module app.services {
    "use strict";

    export namespace education {
        export class StudiskaProgramaService extends base.ServiceBase implements IStudiskaProgramaService {

            constructor() {
                super();
            }

            public site(): ng.IPromise<app.model.education.StudiskaPrograma[]> {

                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.get("api/education/studiskaprograma/site", config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.education.StudiskaPrograma[]>): app.model.education.StudiskaPrograma[] => {
                        return response.data;
                    });
            }

            public nova(novaStudiskaPrograma: app.model.education.StudiskaPrograma): ng.IPromise<app.model.education.StudiskaPrograma> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/education/studiskaprograma/nova", novaStudiskaPrograma, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.education.StudiskaPrograma>): app.model.education.StudiskaPrograma => {
                        return response.data;
                    });
            }

            public izmeni(studiskaprograma: app.model.education.StudiskaPrograma): ng.IPromise<app.model.education.StudiskaPrograma> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/education/studiskaprograma/izmeni", studiskaprograma, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.education.StudiskaPrograma>): app.model.education.StudiskaPrograma => {
                        return response.data;
                    });
            }

        }

        angular
            .module("app.services")
            .service(app.InjectionIds.studiskaprogramaService, StudiskaProgramaService);
    }
}