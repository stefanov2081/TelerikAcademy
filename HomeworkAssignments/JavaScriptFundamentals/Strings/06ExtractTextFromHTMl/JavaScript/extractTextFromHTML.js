/*global document: false */

//function readInput(elementId) {
//    "use strict";

//    var input = document.getElementById(elementId).value;

//    return input;
//}

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

function main() {
    "use strict";

    var result = document.body.outerHTML;

    print('result-2', result);
}