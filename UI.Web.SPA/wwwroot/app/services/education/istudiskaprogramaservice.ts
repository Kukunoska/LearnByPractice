module app.services {
    "use strict";

    export namespace education {
        export interface IStudiskaProgramaService {
            site(): ng.IPromise<app.model.education.StudiskaPrograma[]>;
            nova(studiskaprograma: app.model.education.StudiskaPrograma): ng.IPromise<app.model.education.StudiskaPrograma>;
            izmeni(studiskaprograma: app.model.education.StudiskaPrograma): ng.IPromise<app.model.education.StudiskaPrograma>;
        }
    }
}