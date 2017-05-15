module app.services {
    "use strict"

    export namespace practice {
        export class TehnologijaService extends base.ServiceBase implements ITehnologijaService {

            constructor() {
                super();
            }

            public site(): ng.IPromise<app.model.practice.Tehnologija[]> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.get("api/practice/tehnologija/site", config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.practice.Tehnologija[]>): app.model.practice.Tehnologija[] => {
                        return response.data;
                    });
            }

            public zemi(id: number): ng.IPromise<app.model.practice.Tehnologija> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();
                config.params.id = id;

                return this.$http.get("api/practice/tehnologija/zemi", config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.practice.Tehnologija>): app.model.practice.Tehnologija => {
                        return response.data;
                    });
            }

            public nov(novaTehnologija: app.model.practice.Tehnologija): ng.IPromise<app.model.practice.Tehnologija> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/practice/tehnologija/nov", novaTehnologija, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.practice.Tehnologija>): app.model.practice.Tehnologija => {
                        return response.data;
                    });
            }

            public izmeni(tehnologija: app.model.practice.Tehnologija): ng.IPromise<app.model.practice.Tehnologija> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/practice/tehnologija/izmeni", tehnologija, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.practice.Tehnologija>): app.model.practice.Tehnologija => {
                        return response.data;
                    });
            }

            public izbrishi(tehnologija: app.model.practice.Tehnologija): ng.IPromise<app.model.practice.Tehnologija> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/practice/tehnologija/izbrishi", tehnologija, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.practice.Tehnologija>): app.model.practice.Tehnologija => {
                        return response.data;
                    });
            }
        }
    }
}