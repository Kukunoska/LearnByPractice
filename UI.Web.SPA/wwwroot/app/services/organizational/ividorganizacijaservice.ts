module app.services {
    "use strict";

    export namespace organizational {
        export interface IVidOrganizacijaService {
            site(): ng.IPromise<app.model.organizational.VidOrganizacija[]>;
            zemi(id: number): ng.IPromise<app.model.organizational.VidOrganizacija>;
            nov(vidOrganizacija: app.model.organizational.VidOrganizacija): ng.IPromise<app.model.organizational.VidOrganizacija>;
            izmeni(vidOrganizacija: app.model.organizational.VidOrganizacija): ng.IPromise<app.model.organizational.VidOrganizacija>;
            izbrishi(vidOrganizacija: app.model.organizational.VidOrganizacija): ng.IPromise<app.model.organizational.VidOrganizacija>;
        }
    }
}