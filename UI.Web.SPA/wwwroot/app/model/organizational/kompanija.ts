module app.model {
    "use strict";

    export namespace organizational {
        export class Kompanija {

            public id: number;
            public ime: string;
            public adresa: string;
            public kontaktTelefon: string;
            public vebStrana: string;
            public vidOrganizacija: VidOrganizacija = new VidOrganizacija();
        }
    }
}