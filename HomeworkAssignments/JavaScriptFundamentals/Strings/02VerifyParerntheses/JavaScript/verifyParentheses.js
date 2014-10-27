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

function verifyParentheses(expression) {
    "use strict";

    var i, openedParetheses = false, correct = false, hasParentheses = false, currentSymbol;

    if (expression !== '' && ' ') {
        for (i = 0; i < expression.length; i += 1) {
            currentSymbol = expression[i];

            if (currentSymbol === '(') {
                openedParetheses = true;
                hasParentheses = true;
                correct = false;
            } else if (currentSymbol === ')' && openedParetheses) {
                openedParetheses = false;
                correct = true;
            }

            if (currentSymbol === ')') {
                hasParentheses = true;
            }
        }

        if (!hasParentheses) {
            return 'The expression has no parentheses';
        }

        return correct ? 'Parentheses are correct' : 'Missing or missmatched parentheses';
    }

    return 'Invalid expression';
}

function main() {
    "use strict";

    var expression;

    expression = readInput('input');
    expression = verifyParentheses(expression);
    print('result', expression);
}