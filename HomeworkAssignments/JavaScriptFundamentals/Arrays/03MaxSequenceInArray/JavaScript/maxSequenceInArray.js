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

function maxSequenceInArray() {
    "use strict";

    var i, result = '', current, count = 1, maxCount = 1;

    for (i = 1; i < inputToArray.length; i += 1) {
        current = inputToArray[i - 1];

        if (current === inputToArray[i]) {
            count += 1;

            if (count > maxCount) {
                maxCount = count;
                result = new Array(maxCount + 1).join(current + ', '); // Equal to new string(current, maxCount); in C#;
            }
        } else {
            count = 1;
        }
    }

    result = result.substring(0, result.length - 2); // Remove last space and comma
    document.getElementById('result').innerHTML = result + ' appears ' + maxCount + ' times.';
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
        maxSequenceInArray();
    } else {
        document.getElementById('result').innerHTML = 'Incorrect input!';
    }
}