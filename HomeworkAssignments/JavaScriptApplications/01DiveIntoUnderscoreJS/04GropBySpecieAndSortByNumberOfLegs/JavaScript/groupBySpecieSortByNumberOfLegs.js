/// <reference path="../Libs/underscore.js" />
/*global document: false */

function print(message) {
    "use strict";

    document.getElementById('result').innerHTML += '<p>' + message + '</p>';
}

function groupByAnimals(arrayOfAnimals) {
    "use strict";

    var filteredAnimals,

    filteredAnimals = _.groupBy(arrayOfAnimals,
        function (animal) {
            "use strict"

            return animal.specie;
        });

    return filteredAnimals;
}

function sortByNumberOfLegs(arrayOfAnimals) {
    "use strict"

    var sortedAnimals = _.clone(arrayOfAnimals);

    sortedAnimals = _.sortBy(sortedAnimals, function (animal) {
        console.log(animal[0].numberOfLegs);
        return animal[0].numberOfLegs;
    });

    return sortedAnimals;
}

function main() {
    "use strict";

    var animalsArray,
        groupedAnimals;

    animalsArray = [
        {
            specie: 'Human',
            numberOfLegs: 2
        },
        {
            specie: 'Tiger',
            numberOfLegs: 4
        },
        {
            specie: 'Fish',
            numberOfLegs: 0
        },
        {
            specie: 'Dragon',
            numberOfLegs: 2
        },
        {
            specie: 'Human',
            numberOfLegs: 2
        }
    ];

    groupedAnimals = groupByAnimals(animalsArray);
    groupedAnimals = sortByNumberOfLegs(groupedAnimals)
    print(JSON.stringify(groupedAnimals));
}