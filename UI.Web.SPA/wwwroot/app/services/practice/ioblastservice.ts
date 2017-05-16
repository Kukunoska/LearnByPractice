module app.services {
    "use strict";

    export namespace practice {
        export interface IOblastService {

            site(): ng.IPromise<app.model.practice.Oblast[]>;
            zemi(id: number): ng.IPromise<app.model.practice.Oblast>;
            nov(oblast: app.model.practice.Oblast): ng.IPromise<app.model.practice.Oblast>;
            izmeni(oblast: app.model.practice.Oblast): ng.IPromise<app.model.practice.Oblast>;
            izbrishi(oblast: app.model.practice.Oblast): ng.IPromise<app.model.practice.Oblast>;
        }
    }
}