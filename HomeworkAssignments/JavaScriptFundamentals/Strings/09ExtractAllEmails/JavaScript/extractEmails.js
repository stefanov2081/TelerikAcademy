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

//String.prototype.replaceAt = function replaceAt(index, character) {
//    "use strict";

//    var leftHandSideResult = this.substr(0, index) + character, rightHandSideResult = this.substr(index + 1);
//    return leftHandSideResult + rightHandSideResult;
//};

function getEmails(text) {
    "use strict";

    var result, regex = /[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}/gi;
    result = text.match(regex);

    return result;
}

function main() {
    "use strict";

    var input = readInput('input'), result;
    result = getEmails(input);

    print('result', 'The result is as follows: ' + result);
}

