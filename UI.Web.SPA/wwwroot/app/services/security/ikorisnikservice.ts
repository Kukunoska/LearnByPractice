module app.services {
    "use strict";

    export namespace security {
        export interface IKorisnikService {
            tekoven(): ng.IPromise<app.model.security.Korisnik>;

            site(): ng.IPromise<app.model.security.Korisnik[]>;
            zemi(id: number): ng.IPromise<app.model.security.Korisnik>;
            nov(korisnik: app.model.security.Korisnik): ng.IPromise<app.model.security.Korisnik>;
            izmeni(korisnik: app.model.security.Korisnik): ng.IPromise<app.model.security.Korisnik>;
            izbrishi(korisnik: app.model.security.Korisnik): ng.IPromise<app.model.security.Korisnik>;
        }
    }
}