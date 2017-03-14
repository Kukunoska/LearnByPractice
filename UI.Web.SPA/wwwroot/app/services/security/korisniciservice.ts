module app.services {
    "use strict";

    export namespace security {
        export class KorisniciService extends base.ServiceBase implements IKorisniciService {
            constructor() {
                super();
            }

            public tekoven(): ng.IPromise<app.model.security.Korisnik> {

                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.get("api/security/korisnici/tekoven", config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.security.Korisnik>): app.model.security.Korisnik => {
                        return response.data;
                    });
            }
        }

        angular
            .module("app.services")
            .service(app.InjectionIds.korisniciService, KorisniciService);
    }
}