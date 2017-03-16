module app.services {
    "use strict";

    export namespace security {
        export interface IKorisnikService {
            tekoven(): ng.IPromise<app.model.security.Korisnik>;
        }
    }
}