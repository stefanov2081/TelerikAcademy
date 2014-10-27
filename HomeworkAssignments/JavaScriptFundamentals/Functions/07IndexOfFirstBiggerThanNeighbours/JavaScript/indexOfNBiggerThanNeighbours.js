/*global document: false */

function readInput(elementId) {
    "use strict";

    var input = document.getElementById(elementId).value;

    return input;
}

function parseArray(array) {
    "use strict";

    var parsedArray = [], i;

    for (i = 0; i < array.length; i += 1) {
        parsedArray.push(parseFloat(array[i]));
    }

    return parsedArray;
}

function validateInput(input) {
    "use strict";

    if (input !== '') {
        if (typeof input === 'number' && !isNaN(input)) {
            return input;
        }
    }

    return 'Incorrect input!';
}

function indexOfNBiggerThanNeighbours(input) {
    "use strict";

    var i;

    for (i = 1; i < input.length - 1; i += 1) {
        if (input[i] > input[i - 1] && input[i] > input[i + 1]) {
            return i;
        }

    }

    return -1;
}

function print(message) {
    "use strict";

    document.getElementById('result').innerHTML = message;
}

function main() {
    "use strict";

    var input, result, i;
    input = readInput('text');
    input = input.split(',');
    input = parseArray(input);
    for (i = 0; i < input.length; i += 1) {
        input[i] = validateInput(input[i]);
    }

    if (input !== 'Incorrect input!') {
        result = indexOfNBiggerThanNeighbours(input);
        print('The first number that is greater than it\'s neighbours has an index of: ' + result);
    } else {
        print('Incorrect input!');

    }
}
