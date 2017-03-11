module app.services {
    "use strict";

    export namespace base {

        export abstract class ServiceBase {

            protected $http: ng.IHttpService;
            
            constructor() {

                let $injector: ng.auto.IInjectorService = angular.injector(["ng"]);
                this.$http = $injector.get<ng.IHttpService>("$http");
            }

            protected requestConfig(): ng.IRequestShortcutConfig {
                let config: ng.IRequestShortcutConfig = {
                    params: {
                    }
                };

                return config;
            }
        }
    }
}