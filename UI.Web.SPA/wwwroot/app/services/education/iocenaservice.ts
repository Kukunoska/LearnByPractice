module app.services {
    "use.strict";

    export namespace education {
        export interface IOcenaService {

            site(): ng.IPromise<app.model.education.Ocena[]>;
            zemi(id: number): ng.IPromise<app.model.education.Ocena>;
            nov(ocena: app.model.education.Ocena): ng.IPromise<app.model.education.Ocena>;
            izmeni(ocena: app.model.education.Ocena): ng.IPromise<app.model.education.Ocena>;
            izbrishi(ocena: app.model.education.Ocena): ng.IPromise<app.model.education.Ocena>;
        }
    }
}