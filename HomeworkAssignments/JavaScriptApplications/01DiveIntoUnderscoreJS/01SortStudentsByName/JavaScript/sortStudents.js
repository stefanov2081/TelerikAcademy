/// <reference path="../Libs/underscore.js" />
/*global document: false */

function print(message) {
    "use strict";

    document.getElementById('result').innerHTML += '<p>' + message + '</p>';
}

function findFirstNameBeforeLastName(arrayOfStudents) {
    "use strict";

    var filteredStudents;

    filteredStudents = _.groupBy(arrayOfStudents,
        function (student) {
            "use strict"

            return student.firstName < student.lastName;
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
            lastName: 'Ivanov'
        },
        {
            firstName: 'Georgi',
            lastName: 'Georgiev'
        },
        {
            firstName: 'Petur',
            lastName: 'Petrov'
        },
        {
            firstName: 'Haralampii',
            lastName: 'Lampiev'
        },
    ];

    studentsArray = findFirstNameBeforeLastName(studentsArray);
    studentsArray = sortByFullName(studentsArray);
    print(JSON.stringify(studentsArray));
}