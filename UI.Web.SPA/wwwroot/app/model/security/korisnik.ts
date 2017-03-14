module app.model {
    "use strict";

    export namespace security {
        export class Korisnik {
            public id: number;
            public username: string;
            public ime: string;
            public prezime: string;
            public email: string;
            public administrator: boolean;
            public mentor: boolean;
            public student: boolean;
        }
    }
}