module app.services {
    "use strict";

    export namespace organizational {
        export interface IVidOrganizacijaService {
            site(): ng.IPromise<app.model.organizational.VidOrganizacija[]>;
        }
    }
}