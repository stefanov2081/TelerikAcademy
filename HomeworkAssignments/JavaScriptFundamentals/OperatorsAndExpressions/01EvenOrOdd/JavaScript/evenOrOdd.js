/*global document: false */

var input;

function evenOrOdd() {
    "use strict";
    input = parseFloat(input);

    // Validate input
    if (typeof input === 'number' && !isNaN(input)) {
        // Check if it is an integer or floating point
        if (input % 1 === 0) {
            if (input % 2 === 0) {
                document.getElementById('result').innerHTML = input + ' is even!';
            } else {
                document.getElementById('result').innerHTML = input + ' is odd!';
            }
        } else {
            document.getElementById('result').innerHTML = input + ' is neither even nor odd!';
        }
    } else {
        document.getElementById('result').innerHTML = 'Incorrect input!';
    }
}

function readInput() {
    "use strict";
    input = document.getElementById('user-input').value;
    evenOrOdd();
}