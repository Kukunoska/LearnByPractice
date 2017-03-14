module app {
    "use strict";

    export class InjectionIds {
        public static get predmetiService(): string {
            return "app.services.predmetiService";
        }

        public static get korisniciService(): string {
            return "app.services.korisniciService";
        }

        public static get indexController(): string {
            return "app.indexController";
        }

        public static get shellController(): string {
            return "app.shellController";
        }

        public static get admin_predmeti_indexController(): string {
            return "app.admin.predmeti.indexController";
        }
    }
}