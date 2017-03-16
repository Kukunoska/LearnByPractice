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
        }

        angular
            .module("app.services")
            .service(app.InjectionIds.predmetService, PredmetService);
    }
}