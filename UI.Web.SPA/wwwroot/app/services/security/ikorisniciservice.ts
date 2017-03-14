module app.services {
    "use strict";

    export namespace security {
        export interface IKorisniciService {
            tekoven(): ng.IPromise<app.model.security.Korisnik>;
        }
    }
}