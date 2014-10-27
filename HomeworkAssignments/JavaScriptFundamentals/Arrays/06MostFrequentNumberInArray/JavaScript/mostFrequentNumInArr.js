/*global document: false */

// Declare variables outside the scope of a function
var input, inputToArray = [];

function readInput() {
    "use strict";

    input = document.getElementById('input').value;
}

function splitInput() {
    "use strict";

    inputToArray = input.split(',');
}

function swap(i, j) {
    "use strict";

    var c = inputToArray[i];
    inputToArray[i] = inputToArray[j];
    inputToArray[j] = c;
}

function mostFrequentNumInArray() {
    "use strict";

    var i, j, result = '', count = 1, maxCount = 1;

    for (j = 0; j < inputToArray.length; j += 1) {

        for (i = j + 1; i < inputToArray.length; i += 1) {
            if (inputToArray[i] === inputToArray[j]) {
                count += 1;
            }
        }

        if (count > maxCount) {
            maxCount = count;
            result = inputToArray[j];
        }

        count = 1;
    }

    document.getElementById('result').innerHTML = 'Number ' + result + ' appears ' + maxCount + ' times.';
}

function validateInput() {
    "use strict";

    var i, valid = true;

    for (i = 0; i < inputToArray.length; i += 1) {
        inputToArray[i] = parseFloat(inputToArray[i]);

        if (typeof inputToArray[i] !== 'number' || isNaN(inputToArray[i])) {
            valid = false;
        }
    }

    if (valid) {
        mostFrequentNumInArray();
    } else {
        document.getElementById('result').innerHTML = 'Incorrect input!';
    }
}