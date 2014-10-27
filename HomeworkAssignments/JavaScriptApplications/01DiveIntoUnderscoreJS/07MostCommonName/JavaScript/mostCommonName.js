/// <reference path="../Libs/underscore.js" />
/*global document: false */

function print(message) {
    "use strict";

    document.getElementById('result').innerHTML += '<p>' + message + '</p>';
}

function mostCommonName(people) {
    "use strict"

    var mostCommonName, mostPopularAuthorArray = [];

    mostCommonName = _.groupBy(people, ('firstName' + 'lastName'));
    mostCommonName = _.sortBy(mostCommonName, function (g) { return -g.length });
    
    return _.first(mostCommonName)[0].firstName + ' ' + _.first(mostCommonName)[0].lastName;
}

function main() {
    "use strict";

    var people,
        theMostCommonName;

    people = [
        {
            firstName: 'Ivan',
            lastName: 'Ivanov'
        },
        {
            firstName: 'Georgi',
            lastName: 'Georgiev'
        },
        {
            firstName: 'Ivan',
            lastName: 'Ivanov'
        },
        {
            firstName: 'Haralampii',
            lastName: 'Lampiev'
        },
    ];

    theMostCommonName = mostCommonName(people);
    print(JSON.stringify(people));
    print('Most popular author is ' + theMostCommonName);
}