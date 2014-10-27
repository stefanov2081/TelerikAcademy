/*global document: false */

function readInput(elementId) {
    "use strict";

    var input = document.getElementById(elementId).value;

    return input;
}

function validateInput(input) {
    "use strict";

    input = parseFloat(input);

    if (input % 1 === 0) {
        if (typeof input === 'number' && !isNaN(input)) {
            return input;
        }
    }

    return 'Incorrect input!';
}

function print(elementId, message) {
    "use strict";

    document.getElementById(elementId).innerHTML = message;
}

function personCostructor(fname, lname, age) {
    "use strict";

    return {
        firstName: fname,
        lastName: lname,
        age: age,
        toString: function () {
            return 'Full name: ' + this.firstName + ' ' + this.lastName + ', age: ' + this.age;
        }
    };
}

function findYoungestPerson(arrayOfPersons) {
    "use strict";

    if (arrayOfPersons.length > 0) {
        var youngest = arrayOfPersons[0], i;

        for (i = 1; i < arrayOfPersons.length; i += 1) {
            if (youngest.age > arrayOfPersons[i]) {
                youngest = arrayOfPersons[i];
            }
        }

        return youngest;
    }

    return 'The array is empty';
}

function main() {
    "use strict";

    var gosho = personCostructor('Gosho', 'Petrov', 32), bayIvan = personCostructor('Bay', 'Ivan', 81), array = [], result;
    array.push(gosho);
    array.push(bayIvan);

    print('more-info', 'There are two man: ' + gosho.toString() + ', and ' + bayIvan.toString());
    result = findYoungestPerson(array);
    print('result', 'Younget person is: ' + result);
}