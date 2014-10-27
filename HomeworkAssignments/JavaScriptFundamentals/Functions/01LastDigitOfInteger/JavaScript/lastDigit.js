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

function lastDigit(input) {
    "use strict";

    switch (input % 10) {
    case 0:
        return 'Zero (Rei)';
    case 1:
        return 'One (Ichi)';
    case 2:
        return 'Two (Ni)';
    case 3:
        return 'Tree (San)';
    case 4:
        return 'Four (Shi)';
    case 5:
        return 'Five (Go)';
    case 6:
        return 'Six (Roku)';
    case 7:
        return 'Seven (Shichi)';
    case 8:
        return 'Eight (Hachi)';
    case 9:
        return 'Nine (Kyu)';
    default:
        return 'I can count only to nine :(';
    }
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
        result = lastDigit(input);
        print('Last digit is: ' + result);
    } else {
        print('Incorrect input!');

    }
}