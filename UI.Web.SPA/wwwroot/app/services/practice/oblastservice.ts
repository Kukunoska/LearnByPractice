module app.services {
    "use strict";

    export namespace practice {
        export class OblastService extends base.ServiceBase implements IOblastService {

            constructor() {
                super();
            }

            public site(): ng.IPromise<app.model.practice.Oblast[]> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.get("api/practice/oblast/site", config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.practice.Oblast[]>): app.model.practice.Oblast[] => {
                        return response.data;
                    });
            }

            public zemi(id: number): ng.IPromise<app.model.practice.Oblast> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();
                config.params.id = id;

                return this.$http.get("api/practice/oblast/zemi", config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.practice.Oblast>): app.model.practice.Oblast => {
                        return response.data;
                    });
            }

            public nov(novaOblast: app.model.practice.Oblast): ng.IPromise<app.model.practice.Oblast> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/practice/oblast/nov", novaOblast, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.practice.Oblast>): app.model.practice.Oblast => {
                        return response.data;
                    });
            }

            public izmeni(oblast: app.model.practice.Oblast): ng.IPromise<app.model.practice.Oblast> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/practice/oblast/izmeni", oblast, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.practice.Oblast>): app.model.practice.Oblast => {
                        return response.data;
                    });
            }

            public izbrishi(oblast: app.model.practice.Oblast): ng.IPromise<app.model.practice.Oblast> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/practice/oblast/izbrishi", oblast, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.practice.Oblast>): app.model.practice.Oblast => {
                        return response.data;
                    });
            }
        }
        angular
            .module("app.services")
            .service(app.InjectionIds.oblastService, OblastService);
    }
}