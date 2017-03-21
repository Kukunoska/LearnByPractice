module app.services {
    "use strict";

    export namespace organizational {
        export interface IOrganizacijaService {
            site(): ng.IPromise<app.model.organizational.Organizacija[]>;
            zemi(id: number): ng.IPromise<app.model.organizational.Organizacija>;
            nova(organizacija: app.model.organizational.Organizacija): ng.IPromise<app.model.organizational.Organizacija>;
            izmeni(organizacija: app.model.organizational.Organizacija): ng.IPromise<app.model.organizational.Organizacija>;
            izbrishi(organizacija: app.model.organizational.Organizacija): ng.IPromise<app.model.organizational.Organizacija>;
        }
    }
}