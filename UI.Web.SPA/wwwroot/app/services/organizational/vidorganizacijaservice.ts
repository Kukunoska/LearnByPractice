module app.services {
    "use strict";

    export namespace organizational {
        export class VidOrganizacijaService extends base.ServiceBase implements IVidOrganizacijaService {

            constructor() {
                super();
            }

            public site(): ng.IPromise<app.model.organizational.VidOrganizacija[]> {

                let config: ng.IRequestShortcutConfig = super.requestConfig();

                return this.$http.get("api/organizational/vidorganizacija/site", config)
                    .then((response: ng.IHttpPromiseCallbackArg<app.model.organizational.VidOrganizacija[]>): app.model.organizational.VidOrganizacija[] => {
                        return response.data;
                    });
            }
        }

        angular
            .module("app.services")
            .service(app.InjectionIds.vidOrganizacijaService, VidOrganizacijaService);
    }
}