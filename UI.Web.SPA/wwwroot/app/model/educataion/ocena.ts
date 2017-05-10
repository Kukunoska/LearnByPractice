module app.model {
    "use strict";

    export namespace education {
        export class Ocena {
            public student: security.Korisnik = new security.Korisnik();
            public predmet: Predmet = new Predmet;
            public ocena: number;
        }
    }
}