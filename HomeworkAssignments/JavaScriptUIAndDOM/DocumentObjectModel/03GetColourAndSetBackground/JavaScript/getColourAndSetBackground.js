/*global document: false */
/*global location: false */

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

//function print(elementId, message) {
//    "use strict";

//    document.getElementById(elementId).innerHTML = message;
//}

//function clearDomElement(elementId) {
//    "use strict";

//    document.getElementById(elementId).innerHTML = '';
//}

function readInputByTagAndType(elementTag, attributeName, attributeType) {
    "use strict";

    var input, i, length, result;

    input = document.getElementsByTagName(elementTag);
    length = input.length;

    for (i = 0; i < length; i += 1) {

        if (input[i].getAttribute(attributeName) === attributeType) {
            result = input[i].value;
        }
    }

    return result;
}

function changeBodyColour(colour) {
    document.body.style.background = colour;
}

function main() {
    "use strict";

    var result = readInputByTagAndType('input', 'type', 'color');
    changeBodyColour(result);
}