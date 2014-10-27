/*global document: false */

var input;

function divisibleBy5And7() {
    "use strict";
    input = parseFloat(input);

    // Validate input and check x / 5 && x / 7
    if (typeof input === 'number' && !isNaN(input)) {
        if (input % 5 === 0 && input % 7 === 0) {
            document.getElementById('result').innerHTML = input + ' is divisible by 5 and 7 in the same time!';
        } else {
            document.getElementById('result').innerHTML = input + ' is NOT divisible by 5 and 7 in the same time!';
        }
    } else {
        document.getElementById('result').innerHTML = 'Incorrect input!';
    }
}

function readInput() {
    "use strict";
    input = document.getElementById('user-input').value;
    divisibleBy5And7();
}