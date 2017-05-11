module app.services {
    "use strict";

    export namespace education {
        export class StudiskaProgramaService extends base.ServiceBase implements IStudiskaProgramaService {

            constructor() {
                super();
            }

            public site(): ng.IPromise<app.model.education.StudiskaPrograma[]> {

                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.get("api/education/studiskaPrograma/site", config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.education.StudiskaPrograma[]>): app.model.education.StudiskaPrograma[] => {
                        return response.data;
                    });
            }

            public zemi(id: number): ng.IPromise<app.model.education.StudiskaPrograma> {

                let config: ng.IRequestShortcutConfig = super.requestConfig();
                config.params.id = id;

                return this.$http.get("api/education/studiskaPrograma/zemi", config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.education.StudiskaPrograma>): app.model.education.StudiskaPrograma => {
                        return response.data;
                    });
            }

            public nov(novaStudiskaPrograma: app.model.education.StudiskaPrograma): ng.IPromise<app.model.education.StudiskaPrograma> {

                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("app/educaton/studiskaPrograma/nov", novaStudiskaPrograma, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.education.StudiskaPrograma>): app.model.education.StudiskaPrograma => {
                        return response.data;
                    });
            }

            public izmeni(studiskaPrograma: app.model.education.StudiskaPrograma): ng.IPromise<app.model.education.StudiskaPrograma> {

                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/education/studiskaPrograma/izmeni", studiskaPrograma, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.education.StudiskaPrograma>): app.model.education.StudiskaPrograma => {
                        return response.data;
                    });
            }

            public izbrishi(studiskaPrograma: app.model.education.StudiskaPrograma): ng.IPromise<app.model.education.StudiskaPrograma> {

                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/education/studiskaPrograma/izbrishi", studiskaPrograma, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.education.StudiskaPrograma>): app.model.education.StudiskaPrograma => {
                        return response.data;
                    });
            }
        }

        angular
            .module("app.service")
            .service(app.InjectionIds.studiskaProgramaService, StudiskaProgramaService);
    }
}