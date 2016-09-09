/// <reference path="knockout.d.ts" />
module ambientDeclarations {
    "use strict";


    declare var ko: KnockoutStatic;

    var name: KnockoutObservable<string> = ko.observable("Rick");
    var id:  KnockoutObservable<number> = ko.observable(1);

    var guy = {
        id: id,
        fullName: name
    };

    var value: string = guy.fullName();
    console.log(value);

}