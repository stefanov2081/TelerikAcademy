/// <reference path="../Libs/underscore.js" />
/*global document: false */

function print(message) {
    "use strict";

    document.getElementById('result').innerHTML += '<p>' + message + '</p>';
}

function findStudentWithHighestMarks(arrayOfStudents) {
    "use strict";

    var filteredStudents,
        highestMarkStudent;

    filteredStudents = _.groupBy(arrayOfStudents,
        function (student) {
            "use strict"

            var i,
                highestMark = 0,
                currentMarksSum = 0,
                lastStudentName = arrayOfStudents[0].firstName + ' ' + arrayOfStudents[0].lastName;

            _.each(student.marks, function (value) {
                "use strict"

                for (var i = 0; i < value.length; i++) {

                    if ((student.firstName + ' ' + student.lastName) === lastStudentName) {
                        currentMarksSum += parseInt(value, 10);
                    } else {
                        lastStudentName = student.firstName + ' ' + student.lastName;
                    }

                    if (highestMark < currentMarksSum) {
                        highestMark = currentMarksSum;
                        highestMarkStudent = student;
                    }
                }

                currentMarksSum = 0;
            });
        });

    return highestMarkStudent;
}

function main() {
    "use strict";

    var studentsArray,
       highestMarkStudent;

    studentsArray = [
        {
            firstName: 'Ivan',
            lastName: 'Ivanov',
            age: 26,
            marks: {
                english: [4, 4, 5],
                math: [3, 4, 5],
                geography: [6, 6, 6]
            }
        },
        {
            firstName: 'Georgi',
            lastName: 'Georgiev',
            age: 19,
            marks: {
                english: [2, 2, 2],
                math: [3, 4, 5],
                geography: [6, 6, 6]
            }

        },
        {
            firstName: 'Petur',
            lastName: 'Petrov',
            age: 20,
            marks: {
                english: [6, 6, 6],
                math: [3, 4, 5],
                geography: [2, 2, 2]
            }
        },
        {
            firstName: 'Haralampii',
            lastName: 'Lampiev',
            age: 14,
            marks: {
                english: [6, 6, 6],
                math: [6, 6, 6],
                geography: [6, 6, 6]
            }
        },
    ];

    highestMarkStudent = findStudentWithHighestMarks(studentsArray);
    print(JSON.stringify(highestMarkStudent));
}