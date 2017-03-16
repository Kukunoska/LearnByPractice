module app.services {
    "use strict";

    export namespace security {
        export class KorisnikService extends base.ServiceBase implements IKorisnikService {
            constructor() {
                super();
            }

            public tekoven(): ng.IPromise<app.model.security.Korisnik> {

                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.get("api/security/korisnik/tekoven", config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.security.Korisnik>): app.model.security.Korisnik => {
                        return response.data;
                    });
            }
        }

        angular
            .module("app.services")
            .service(app.InjectionIds.korisnikService, KorisnikService);
    }
}