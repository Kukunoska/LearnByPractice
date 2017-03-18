module app.services {
    "use strict";

    export namespace education {
        export class PredmetService extends base.ServiceBase implements IPredmetService {

            constructor() {
                super();
            }

            public site(): ng.IPromise<app.model.education.Predmet[]> {

                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.get("api/education/predmet/site", config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.education.Predmet[]>): app.model.education.Predmet[] => {
                        return response.data;
                    });
            }

            public zemi(id: number): ng.IPromise<app.model.education.Predmet> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();
                config.params.id = id;

                return this.$http.get("api/education/predmet/zemi", config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.education.Predmet>): app.model.education.Predmet => {
                        return response.data;
                    });
            }

            public nov(novPredmet: app.model.education.Predmet): ng.IPromise<app.model.education.Predmet> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/education/predmet/nov", novPredmet, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.education.Predmet>): app.model.education.Predmet=> {
                        return response.data;
                    });
            }

            public izmeni(predmet: app.model.education.Predmet): ng.IPromise<app.model.education.Predmet> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/education/predmet/izmeni", predmet, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.education.Predmet>): app.model.education.Predmet => {
                        return response.data;
                    });
            }

            public izbrishi(predmet: app.model.education.Predmet): ng.IPromise<app.model.education.Predmet> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/education/predmet/izbrishi", predmet, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.education.Predmet>): app.model.education.Predmet => {
                        return response.data;
                    });
            }
        }

        angular
            .module("app.services")
            .service(app.InjectionIds.predmetService, PredmetService);
    }
}