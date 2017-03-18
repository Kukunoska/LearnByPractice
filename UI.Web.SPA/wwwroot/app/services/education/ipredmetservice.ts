module app.services {
    "use strict";

    export namespace education {
        export interface IPredmetService {
            site(): ng.IPromise<app.model.education.Predmet[]>;
            zemi(id: number): ng.IPromise<app.model.education.Predmet>;
            nov(predmet: app.model.education.Predmet): ng.IPromise<app.model.education.Predmet>;
            izmeni(predmet: app.model.education.Predmet): ng.IPromise<app.model.education.Predmet>;
            izbrishi(predmet: app.model.education.Predmet): ng.IPromise<app.model.education.Predmet>;
        }
    }
}