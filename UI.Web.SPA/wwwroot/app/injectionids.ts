module app {
    "use strict";

    export class InjectionIds {
        // сервиси
        public static get predmetService(): string {
            return "app.services.predmetService";
        }

        public static get korisnikService(): string {
            return "app.services.korisnikService";
        }

        public static get vidOrganizacijaService(): string {
            return "app.services.vidOrganizacijaService";
        }

        public static get kompanijaService(): string {
            return "app.services.kompanijaService";
        }

        // контролери (root)
        public static get indexController(): string {
            return "app.indexController";
        }

        public static get shellController(): string {
            return "app.shellController";
        }

        // контролери (администратор)
        public static get admin_predmeti_indexController(): string {
            return "app.admin.predmeti.indexController";
        }

        public static get admin_predmeti_vnesuvanjeController(): string {
            return "app.admin.predmeti.vnesuvanjeController";
        }

        public static get admin_kompanii_indexController(): string {
            return "app.admin.kompanii.indexController";
        }

        public static get admin_kompanii_vnesuvanjeController(): string {
            return "app.admin.kompanii.vnesuvanjeController";
        }
    }
}