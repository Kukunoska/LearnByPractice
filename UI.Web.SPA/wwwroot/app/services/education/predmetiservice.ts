module app.services {
    "use strict";

    export namespace education {
        export class PredmetiService extends base.ServiceBase implements IPredmetiService {

            constructor() {
                super();
            }

            public site(): ng.IPromise<app.model.education.Predmet[]> {

                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.get("api/admin/predmeti/site", config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.education.Predmet[]>): app.model.education.Predmet[] => {
                        return response.data;
                    });
            }
        }

        angular
            .module("app.services")
            .service(app.InjectionIds.predmetiService, PredmetiService);
    }
}