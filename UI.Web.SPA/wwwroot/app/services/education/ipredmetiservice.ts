module app.services {
    "use strict";

    export namespace education {
        export interface IPredmetiService {
            site(): ng.IPromise<app.model.education.Predmet[]>;
        }
    }
}