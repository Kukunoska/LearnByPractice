module app.services {
    "use strict";

    export namespace education {
        export interface IPredmetService {
            site(): ng.IPromise<app.model.education.Predmet[]>;
        }
    }
}