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

function countAppearenceOfSubstring(text, searchedSubstring) {
    "use strict";

    var i, currentSubstring, count = 0;

    if (text !== '' && ' ') {
        text = text.toLowerCase();
        searchedSubstring = searchedSubstring.toLowerCase();

        for (i = 0; i < text.length; i += 1) {
            if (i + searchedSubstring.length < text.length) {
                currentSubstring = text.substr(i, searchedSubstring.length);
            }

            if (currentSubstring === searchedSubstring) {
                count++;
            }
        }

        return count;
    }

    return 'Input is empty';
}

function main() {
    "use strict";

    var text = 'We are living in an yellow submarine. We don\'t have anything else. ' +
        'Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.', searchedSubstring = 'in', result;

    result = countAppearenceOfSubstring(text, searchedSubstring);
    print('more-info', text);
    print('result', 'Substring ' + searchedSubstring + ' appears in the text ' + result + ' times.');
}