/*global document: false */
/*jslint plusplus: true */

// Declare variables outside the scope of a function
var input;
var inputArray;

function minAndMaxNumberInArray() {
    "use strict";

    var i, min = inputArray[0], max = inputArray[0];

    for (i = 0; i < inputArray.length; i += 1) {
        if (inputArray[i] < min) {
            min = inputArray[i];
        } else if (inputArray[i] > max) {
            max = inputArray[i];
        }
    }

    document.getElementById('result').innerHTML = 'Min number: ' + min + '<br />' + 'Max number: ' + max;
}

function validateInput() {
    "use strict";
    var i, valid = true;

    for (i = 0; i < inputArray.length; i += 1) {
        inputArray[i] = parseFloat(inputArray[i]);

        if (!(typeof inputArray[i] === 'number' && !isNaN(inputArray[i]))) {
            valid = false;
        }
    }

    if (valid) {
        minAndMaxNumberInArray();
    } else {
        document.getElementById('result').innerHTML = 'Incorrect input!';
    }
}

function splitInput() {
    "use strict";
    inputArray = input.split(',');
    validateInput();
}

function readInput() {
    "use strict";

    input = document.getElementById('input').value;
    splitInput();
}