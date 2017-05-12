var app;
(function (app) {
    "use strict";
    var InjectionIds = (function () {
        function InjectionIds() {
        }
        Object.defineProperty(InjectionIds, "predmetService", {
            // сервиси
            get: function () {
                return "app.services.predmetService";
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(InjectionIds, "ocenaService", {
            get: function () {
                return "app.services.ocenaService";
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(InjectionIds, "studiskaProgramaService", {
            get: function () {
                return "app.services.studiskaProgramaService";
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(InjectionIds, "korisnikService", {
            get: function () {
                return "app.services.korisnikService";
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(InjectionIds, "vidOrganizacijaService", {
            get: function () {
                return "app.services.vidOrganizacijaService";
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(InjectionIds, "organizacijaService", {
            get: function () {
                return "app.services.organizacijaService";
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(InjectionIds, "indexController", {
            // контролери (root)
            get: function () {
                return "app.indexController";
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(InjectionIds, "shellController", {
            get: function () {
                return "app.shellController";
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(InjectionIds, "user_editProfileController", {
            // контролери (user)
            get: function () {
                return "app.user.editProfileController";
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(InjectionIds, "user_changePasswordController", {
            get: function () {
                return "app.user.changePasswordController";
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(InjectionIds, "admin_homeController", {
            // контролери (администратор)
            get: function () {
                return "app.admin.homeController";
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(InjectionIds, "admin_vidoviOrganizacii_indexController", {
            get: function () {
                return "app.admin.vidoviOrganizacii.indexController";
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(InjectionIds, "admin_vidoviOrganizacii_vnesuvanjeController", {
            get: function () {
                return "app.admin.vidoviOrganizacii.vnesuvanjeController";
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(InjectionIds, "admin_predmeti_indexController", {
            get: function () {
                return "app.admin.predmeti.indexController";
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(InjectionIds, "admin_predmeti_vnesuvanjeController", {
            get: function () {
                return "app.admin.predmeti.vnesuvanjeController";
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(InjectionIds, "admin_organizacii_indexController", {
            get: function () {
                return "app.admin.organizacii.indexController";
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(InjectionIds, "admin_organizacii_vnesuvanjeController", {
            get: function () {
                return "app.admin.organizacii.vnesuvanjeController";
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(InjectionIds, "admin_studiskaPrograma_indexController", {
            get: function () {
                return "app.admin.studiskaPrograma.indexController";
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(InjectionIds, "admin_studiskaPrograma_vnesuvanjeController", {
            get: function () {
                return "app.admin.studiskaPrograma.vnesuvanjeController";
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(InjectionIds, "mentor_homeController", {
            // контролери (ментор)
            get: function () {
                return "app.mentor.homeController";
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(InjectionIds, "student_homeController", {
            // контролери (студент)
            get: function () {
                return "app.strudent.homeController";
            },
            enumerable: true,
            configurable: true
        });
        return InjectionIds;
    }());
    app.InjectionIds = InjectionIds;
})(app || (app = {}));
