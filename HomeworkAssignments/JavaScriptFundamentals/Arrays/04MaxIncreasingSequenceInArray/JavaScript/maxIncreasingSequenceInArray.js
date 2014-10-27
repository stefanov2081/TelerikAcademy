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

function maxIncreasingSequenceInArray() {
    "use strict";

    var i, j, result = '', current, count = 1, maxCount = 1;

    for (i = 1; i < inputToArray.length; i += 1) {
        current = inputToArray[i - 1];

        if ((current + 1) === inputToArray[i]) {
            count += 1;

            if (count > maxCount) {
                maxCount = count;

                // Write the sequence in result to print in later
                result = (current - (maxCount - 2));
                for (j = 1; j < maxCount; j += 1) {
                    result += ', ' + ((current - (maxCount - 2)) + j);
                }
            }
        } else {
            count = 1;
        }
    }

    document.getElementById('result').innerHTML = result + ' is the largest increasing sequence, and is made out of ' + maxCount + ' numbers.';
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
        maxIncreasingSequenceInArray();
    } else {
        document.getElementById('result').innerHTML = 'Incorrect input!';
    }
}