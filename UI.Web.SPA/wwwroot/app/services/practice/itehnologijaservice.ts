module app.services {
    "use strict";

    export namespace practice {
        export interface ITehnologijaService {

            site(): ng.IPromise<app.model.practice.Tehnologija[]>;
            zemi(id: number): ng.IPromise<app.model.practice.Tehnologija>;
            nov(tehnologija: app.model.practice.Tehnologija): ng.IPromise<app.model.practice.Tehnologija>;
            izmeni(tehnologija: app.model.practice.Tehnologija): ng.IPromise<app.model.practice.Tehnologija>;
            izbrishi(tehnologija: app.model.practice.Tehnologija): ng.IPromise<app.model.practice.Tehnologija>;
        }
    }
}