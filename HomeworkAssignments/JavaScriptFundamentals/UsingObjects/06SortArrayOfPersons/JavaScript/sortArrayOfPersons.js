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

function sortArrayOfPersons(arrayOfPersons, byAge, byFName, byLName) {
    "use strict";

    if (arrayOfPersons.length > 0) {
        var i, j, swapPlaces;

        // Sort the array in descending order...
        if (byAge !== undefined) {
            for (i = 0; i < arrayOfPersons.length; i += 1) {
                for (j = i + 1; j < arrayOfPersons.length; j += 1) {
                    if (arrayOfPersons[j].age < arrayOfPersons[i].age) {
                        swapPlaces = arrayOfPersons[i];
                        arrayOfPersons[i] = arrayOfPersons[j];
                        arrayOfPersons[j] = swapPlaces;
                    }
                }
            }
        } else if (byFName !== undefined) {
            for (i = 0; i < arrayOfPersons.length; i += 1) {
                for (j = i + 1; j < arrayOfPersons.length; j += 1) {
                    if (arrayOfPersons[j].firstName < arrayOfPersons[i].firstName) {
                        swapPlaces = arrayOfPersons[i];
                        arrayOfPersons[i] = arrayOfPersons[j];
                        arrayOfPersons[j] = swapPlaces;
                    }
                }
            }
        } else if (byLName !== undefined) {
            for (i = 0; i < arrayOfPersons.length; i += 1) {
                for (j = i + 1; j < arrayOfPersons.length; j += 1) {
                    if (arrayOfPersons[j].lastName < arrayOfPersons[i].lastName) {
                        swapPlaces = arrayOfPersons[i];
                        arrayOfPersons[i] = arrayOfPersons[j];
                        arrayOfPersons[j] = swapPlaces;
                    }
                }
            }
        }

        return arrayOfPersons;
    }

    return 'The array is empty';
}

function main() {
    "use strict";

    var gosho = personCostructor('Gosho', 'Petrov', 32), bayIvan = personCostructor('Bay', 'Ivan', 81),
        pesho = personCostructor('Pesho', 'Goshov', 54), array = [], resultArray = [], result, i;
    array.push(gosho);
    array.push(bayIvan);
    array.push(pesho);

    print('more-info', 'There are three man: ' + gosho.toString() + ', ' + bayIvan.toString() + ', and ' + pesho.toString());

    resultArray = sortArrayOfPersons(array, 'defined');
    result = 'Sorted by age: ';
    for (i = 0; i < resultArray.length; i += 1) {
        result += resultArray[i].toString() + ';';
    }

    resultArray = [];
    resultArray = sortArrayOfPersons(array, undefined, 'defined');
    result += 'Sorted by first name: ';
    for (i = 0; i < resultArray.length; i += 1) {
        result += resultArray[i].toString() + ';';
    }

    resultArray = [];
    resultArray = sortArrayOfPersons(array, undefined, undefined, 'defined');
    result += 'Sorted by last name: ';
    for (i = 0; i < resultArray.length; i += 1) {
        result += resultArray[i].toString() + ';';
    }

    print('result', result);
}