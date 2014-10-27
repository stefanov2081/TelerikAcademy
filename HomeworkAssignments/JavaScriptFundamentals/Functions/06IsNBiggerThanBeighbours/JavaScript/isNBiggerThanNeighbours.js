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

function isNBiggerThanNeighbours(index, input) {
    "use strict";

    if (index > 0 && index < input.length - 1) {
        if (input[index] > input[index - 1] && input[index] > input[index + 1]) {
            return 'The element with index ' + index + ' is greater than it\'s neighbours';
        }

        return 'The element with index ' + index + ' is NOT greater than it\'s neighbours';
    }
    if (index < input.length) {
        return 'The element with index ' + index + ' does not have two neighbours';
    }

    return 'Index outside of range';

}

function print(message) {
    "use strict";

    document.getElementById('result').innerHTML = message;
}

function main() {
    "use strict";

    var input, key, result, i;
    input = readInput('text');
    key = readInput('key');
    input = input.split(',');
    input = parseArray(input);
    key = parseFloat(key);
    for (i = 0; i < input.length; i += 1) {
        input[i] = validateInput(input[i]);
    }
    key = validateInput(key);

    if (input !== 'Incorrect input!' && key !== 'Incorrect input!') {
        result = isNBiggerThanNeighbours(key, input);
        print(result);
    } else {
        print('Incorrect input!');

    }
}
