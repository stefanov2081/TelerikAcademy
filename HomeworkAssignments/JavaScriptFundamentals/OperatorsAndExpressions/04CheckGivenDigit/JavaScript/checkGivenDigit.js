/*global document: false */
/*jslint plusplus: true */

var number, index;

function readInput() {
    "use strict";
    number = document.getElementById('number').value;
    index = document.getElementById('index').value;
}

function checkDigitAtIndex() {
    "use strict";

    var i, remainder;
    number = parseInt(number, 10);
    index = parseInt(index, 10);

    // Validate input
    if ((typeof number === 'number' && !isNaN(number)) && (typeof index === 'number' && !isNaN(index)) && (number > 0 && index > 0)) {
        for (i = 0; i < index - 1; i++) {
            number = number / 10;
        }

        remainder = number % 10;
        document.getElementById('result').innerHTML = 'The digit at position ' + index + ' ,counting from right to left is: ' + Math.floor(remainder);
    } else {
        document.getElementById('result').innerHTML = 'Incorrect input!';
    }
}