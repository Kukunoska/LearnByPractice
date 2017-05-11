module app {
    "use strict";

    export class InjectionIds {
        // сервиси
        public static get predmetService(): string {
            return "app.services.predmetService";
        }

        public static get ocenaService(): string {
            return "app.services.ocenaService";
        }

        public static get studiskaProgramaService(): string {
            return "app.services.studiskaProgramaService";
        }

        public static get korisnikService(): string {
            return "app.services.korisnikService";
        }

        public static get vidOrganizacijaService(): string {
            return "app.services.vidOrganizacijaService";
        }

        public static get organizacijaService(): string {
            return "app.services.organizacijaService";
        }

        // контролери (root)
        public static get indexController(): string {
            return "app.indexController";
        }

        public static get shellController(): string {
            return "app.shellController";
        }

        // контролери (user)
        public static get user_editProfileController(): string {
            return "app.user.editProfileController";
        }

        public static get user_changePasswordController(): string {
            return "app.user.changePasswordController";
        }

        // контролери (администратор)
        public static get admin_homeController(): string {
            return "app.admin.homeController";
        }

        public static get admin_vidoviOrganizacii_indexController(): string {
            return "app.admin.vidoviOrganizacii.indexController";
        }

        public static get admin_vidoviOrganizacii_vnesuvanjeController(): string {
            return "app.admin.vidoviOrganizacii.vnesuvanjeController";
        }

        public static get admin_predmeti_indexController(): string {
            return "app.admin.predmeti.indexController";
        }

        public static get admin_predmeti_vnesuvanjeController(): string {
            return "app.admin.predmeti.vnesuvanjeController";
        }

        public static get admin_organizacii_indexController(): string {
            return "app.admin.organizacii.indexController";
        }

        public static get admin_organizacii_vnesuvanjeController(): string {
            return "app.admin.organizacii.vnesuvanjeController";
        }

        // контролери (ментор)
        public static get mentor_homeController(): string {
            return "app.mentor.homeController";
        }

        // контролери (студент)
        public static get student_homeController(): string {
            return "app.strudent.homeController";
        }
    }
}