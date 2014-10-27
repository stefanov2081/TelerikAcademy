/// <reference path="../Libs/underscore.js" />
/*global document: false */

function print(message) {
    "use strict";

    document.getElementById('result').innerHTML += '<p>' + message + '</p>';
}

function findStudentsByAgeRange(arrayOfStudents, minAge, maxAge) {
    "use strict";

    var filteredStudents;

    filteredStudents = _.groupBy(arrayOfStudents,
        function (student) {
            "use strict"

            return student.age >= minAge && student.age <= maxAge;
        });

    return filteredStudents.true.slice(0);
}

function sortByFullName(arrayOfStudents) {
    "use strict"

    return _.sortBy(arrayOfStudents,
        function (student) {
            "use strict"

            return student.firstName + student.lastName;
        });
}

function main() {
    "use strict";

    var studentsArray;

    studentsArray = [
        {
            firstName: 'Ivan',
            lastName: 'Ivanov',
            age: 26
        },
        {
            firstName: 'Georgi',
            lastName: 'Georgiev',
            age: 19
        },
        {
            firstName: 'Petur',
            lastName: 'Petrov',
            age: 20
        },
        {
            firstName: 'Haralampii',
            lastName: 'Lampiev',
            age: 14
        },
    ];

    studentsArray = findStudentsByAgeRange(studentsArray, 18, 24);
    studentsArray = sortByFullName(studentsArray);
    print(JSON.stringify(studentsArray));
}