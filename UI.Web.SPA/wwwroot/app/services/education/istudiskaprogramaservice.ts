module app.services {
    "use strict";

    export namespace education {
        export interface IStudiskaProgramaService {


            site(): ng.IPromise<app.model.education.StudiskaPrograma[]>;
            zemi(id: number): ng.IPromise<app.model.education.StudiskaPrograma>;
            nov(studiskaPrograma: app.model.education.StudiskaPrograma): ng.IPromise<app.model.education.StudiskaPrograma>;
            izmeni(studiskaPrograma: app.model.education.StudiskaPrograma): ng.IPromise<app.model.education.StudiskaPrograma>;
            izbrishi(studiskaPrograma: app.model.education.StudiskaPrograma): ng.IPromise<app.model.education.StudiskaPrograma>;
        }

    }
}