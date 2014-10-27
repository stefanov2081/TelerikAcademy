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

String.prototype.replaceAt = function replaceAt(index, character) {
    "use strict";

    var leftHandSideResult = this.substr(0, index) + character, rightHandSideResult = this.substr(index + 1);
    return leftHandSideResult + rightHandSideResult;
};

function main() {
    "use strict";

    var original = '<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>', text = original, i, currentSymbol;

    for (i = 0; i <= text.length; i += 1) {
        currentSymbol = text[i];
        if (text[i] === '<') {
            if (text[i + 1] === 'a') {
                if (text[i + 2] === ' ') {
                    text = text.replaceAt(i, '[');
                    text = text.replaceAt(i + 1, 'U');
                    text = text.replaceAt(i + 2, 'R');
                    text = text.replaceAt(i + 3, 'L');
                    text = text.replaceAt(i + 4, '');
                    text = text.replaceAt(i + 4, '');
                    text = text.replaceAt(i + 4, '');
                    text = text.replaceAt(i + 5, '');
                }
            } else if (text[i + 1] === '/') {
                if (text[i + 2] === 'a') {
                    text = text.replaceAt(i, '[');
                    text = text.replaceAt(i + 2, 'U');
                    text = text.replaceAt(i + 3, 'R');
                    text = text.replaceAt(i + 4, 'L ');
                    text = text.replaceAt(i + 5, ']');
                }
            }
        } else if (text[i] === '"' && text[i + 1] === '>') {
            text = text.replaceAt(i, '');
            text = text.replaceAt(i, ']');

        }
    }

    print('more-info', original);
    print('result', 'The result is as follows: ' + text);
}

