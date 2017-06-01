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

            public site(): ng.IPromise<app.model.security.Korisnik[]> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.get("api/security/korisnik/site", config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.security.Korisnik[]>): app.model.security.Korisnik[] => {
                        return response.data;
                    });
            }

            public zemi(id: number): ng.IPromise<app.model.security.Korisnik> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();
                config.params.id = id;

                return this.$http.get("api/security/korisnik/zemi", config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.security.Korisnik>): app.model.security.Korisnik => {
                        return response.data;
                    });
            }

            public nov(novKorisnik: app.model.security.Korisnik): ng.IPromise<app.model.security.Korisnik> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/security/korisnik/nov", novKorisnik, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.security.Korisnik>): app.model.security.Korisnik => {
                        return response.data;
                    });
            }

            public izmeni(korisnik: app.model.security.Korisnik): ng.IPromise<app.model.security.Korisnik> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/security/korisnik/izmeni", korisnik, config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.security.Korisnik>): app.model.security.Korisnik => {
                        return response.data;
                    });
            }

            public izbrishi(korisnik: app.model.security.Korisnik): ng.IPromise<app.model.security.Korisnik> {
                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.post("api/security/korisnik/izbrishi", korisnik, config)
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