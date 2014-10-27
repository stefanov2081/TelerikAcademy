/// <reference path="../Libs/underscore.js" />
/*global document: false */

function print(message) {
    "use strict";

    document.getElementById('result').innerHTML += '<p>' + message + '</p>';
}

function findTotalNumberOfLegs(arrayOfAnimals) {
    "use strict"

    var sum = 0,
        animalsToReturn = _.clone(arrayOfAnimals);

    animalsToReturn = _.each(arrayOfAnimals, function (animal) {
        "use strict"

        sum += animal.numberOfLegs;
    });

    return sum;
}

function main() {
    "use strict";

    var animalsArray,
        totalNumberOfLegs;

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
        },
        {
            specie: 'Centipede',
            numberOfLegs: 100
        },
        {
            specie: 'Spider',
            numberOfLegs: 8
        }
    ];

    totalNumberOfLegs = findTotalNumberOfLegs(animalsArray);
    print(JSON.stringify(animalsArray));
    print(JSON.stringify('Total number of legs: ' + totalNumberOfLegs));
}