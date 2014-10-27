/*global document: false */

function readInput(elementId) {
    "use strict";

    var input = document.getElementById(elementId).value;

    return input;
}

//function validateInput(input) {
//    "use strict";

//    input = parseFloat(input);

//    if (input % 1 === 0) {
//        if (typeof input === 'number' && !isNaN(input)) {
//            return input;
//        }
//    }

//    return 'Incorrect input!';
//}

function print(elementId, message) {
    "use strict";

    document.getElementById(elementId).innerHTML = message;
}

function reverseAString(string) {
    "use strict";

    var i, reversed = '';

    if (string !== '' && ' ') {
        for (i = 0; i < string.length; i += 1) {
            reversed = string[i] + reversed;
        }

        return reversed;
    }

    return 'The string is empty';
}

function main() {
    "use strict";

    var stringToReverse, reversedString;

    stringToReverse = readInput('input');
    reversedString = reverseAString(stringToReverse);
    print('result', reversedString);
}