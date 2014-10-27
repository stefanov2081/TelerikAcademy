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

// Regex rocks !!!
function stringFormat() {
    "use strict";

    var i, argumentsArray = arguments, string = argumentsArray[0], indexes = string.match(/[0-9]+/g);

    for (i = 1; i < argumentsArray.length; i += 1) {
        string = string.replace(new RegExp('{(' + indexes[i - 1] + ')}', 'g'), argumentsArray[i]);
    }

    return string;
}

function main() {
    "use strict";

    var result = stringFormat('Hello {0} {1} {2} {0} {0} {0} {1} {0} {0}!', 'Peter', 'Gosho', 'Kiro');
    print('result', result);
}