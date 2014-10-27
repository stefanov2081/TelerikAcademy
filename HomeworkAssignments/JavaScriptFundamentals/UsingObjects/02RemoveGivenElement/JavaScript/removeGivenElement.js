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

function removeElementFromArray(array, element) {
    "use strict";

    var i, resultArray = [], changed = false;

    for (i = 0; i < array.length; i += 1) {
        if (array[i] === element) {
            array[i] = undefined;
            changed = true;
        }
    }

    if (changed) {
        for (i = 0; i < array.length; i += 1) {
            if (array[i] !== undefined) {
                resultArray.push(array[i]);
            }
        }
    }

    return resultArray;
}

function print(elementId, message) {
    "use strict";

    document.getElementById(elementId).innerHTML = message;
}

function main() {
    "use strict";

    var inputToArray = [], element, input, i, result = '';

    input = readInput('array');
    element = readInput('element');
    inputToArray = input.split(',');
    inputToArray.removeElement = function (array, element) {

        var resultArray = [], changed = false;

        for (i = 0; i < array.length; i += 1) {
            if (array[i] === element) {
                array[i] = undefined;
                changed = true;
            }
        }

        if (changed) {
            for (i = 0; i < array.length; i += 1) {
                if (array[i] !== undefined) {
                    resultArray.push(array[i]);
                }
            }
        }

        return resultArray;
    };

    inputToArray = inputToArray.removeElement(inputToArray, element);

    for (i = 0; i < inputToArray.length; i += 1) {
        result += inputToArray[i] + ', ';
    }

    result = result.substring(0, result.length - 2);
    print('result', result);
}