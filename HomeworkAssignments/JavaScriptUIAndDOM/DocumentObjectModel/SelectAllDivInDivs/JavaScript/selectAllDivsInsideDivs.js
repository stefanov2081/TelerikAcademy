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

function print(elementId, message) {
    "use strict";

    document.getElementById(elementId).innerHTML = message;
}

//function clearDomElement(elementId) {
//    "use strict";

//    document.getElementById(elementId).innerHTML = '';
//}

function selectQuerySelector() {
    "use strict";

    var result;

    result = document.querySelectorAll('div > div');
    result[0].textContent = 'This text is dynamically added in the child div with the query selector.';
}

function selectByTagName() {
    "use strict";

    var result = [], parentDiv, i, j, length;

    parentDiv = document.getElementsByTagName('div');
    length = parentDiv.length;

    for (i = 0; i < length; i += 1) {

        for (j = 0; j < parentDiv[i].childElementCount; j += 1) {

            if (parentDiv[i].children[j].nodeName === 'DIV') {
                result.push(parentDiv[i].children[j]);
            }
        }
    }

    result[0].innerHTML += '<br /> This text is dynamically added in the child div with the tag name selector';
}

function main() {
    "use strict";

    selectQuerySelector();
    selectByTagName();
}