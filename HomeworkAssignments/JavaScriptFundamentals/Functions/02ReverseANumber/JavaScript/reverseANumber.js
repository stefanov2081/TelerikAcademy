/*global document: false */

function readInput() {
    "use strict";

    var input = document.getElementById('input').value;

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

function reverseANumber(input) {
    "use strict";

    var result = '';

    while (input >= 1) {
        result += Math.floor(input) % 10;
        input = Math.floor(input) / 10;
    }

    return result;
}

function print(message) {
    "use strict";

    document.getElementById('result').innerHTML = message;
}

function main() {
    "use strict";

    var input, result;
    input = readInput();
    input = validateInput(input);

    if (input !== 'Incorrect input!') {
        result = reverseANumber(input);
        print(input + ' reversed is ' + result);
    } else {
        print('Incorrect input!');

    }
}