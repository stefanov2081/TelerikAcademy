/*global document: false */

// Declare variables outside the scope of a function
var inputFirst, inputSecond;

function readInput() {
    "use strict";

    inputFirst = document.getElementById('input-first').value;
    inputSecond = document.getElementById('input-second').value;
}

function compareCharArrays() {
    "use strict";

    var i, result = '', inputFirstToCharrArray = inputFirst.split(''), inputSecondToCharrArray = inputSecond.split(''),
        length = inputSecondToCharrArray.length, smaller = inputFirstToCharrArray, greater = inputSecondToCharrArray;

    if ((inputSecondToCharrArray.length - inputFirstToCharrArray.length) < 0) {
        length = inputFirstToCharrArray.length;
        smaller = inputSecondToCharrArray;
        greater = inputFirstToCharrArray;
    }

    for (i = 0; i < length; i += 1) {
        if (i <= smaller.length - 1) {
            if (smaller[i] === greater[i]) {
                result += smaller[i] + ' = ' + greater[i] + '<br />';
            } else {
                result += smaller[i] + ' != ' + greater[i] + '<br />';
            }
        } else {
            result += 'No char to compare with '  + greater[i] + '<br />';
        }
    }

    document.getElementById('result').innerHTML = result;
}

function validateInput() {
    "use strict";

    if (typeof inputFirst === 'string') {
        compareCharArrays();
    } else {
        document.getElementById('result').innerHTML = 'Incorrect input!';
    }
}