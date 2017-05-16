module app.services {
    "use strict";

    export namespace practice {
        export interface ITehnologijaService {

            site(): ng.IPromise<app.model.practice.Tehnologija[]>;
            zemi(id: number): ng.IPromise<app.model.practice.Tehnologija>;
            nov(oblast: app.model.practice.Oblast): ng.IPromise<app.model.practice.Tehnologija>;
            izmeni(oblast: app.model.practice.Oblast): ng.IPromise<app.model.practice.Tehnologija>;
            izbrishi(oblast: app.model.practice.Oblast): ng.IPromise<app.model.practice.Tehnologija>;
        }
    }
}