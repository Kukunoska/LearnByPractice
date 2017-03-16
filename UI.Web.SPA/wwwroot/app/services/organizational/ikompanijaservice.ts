module app.services {
    "use strict";

    export namespace organizational {
        export interface IKompanijaService {
            site(): ng.IPromise<app.model.organizational.Kompanija[]>;
            zemi(id: number): ng.IPromise<app.model.organizational.Kompanija>;
            nova(novaKompanija: app.model.organizational.Kompanija): ng.IPromise<app.model.organizational.Kompanija>;
            izmeni(kompanija: app.model.organizational.Kompanija): ng.IPromise<app.model.organizational.Kompanija>;
            izbrishi(kompanija: app.model.organizational.Kompanija): ng.IPromise<app.model.organizational.Kompanija>;
        }
    }
}