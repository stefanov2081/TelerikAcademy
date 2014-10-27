/*global document: false */
/*jslint plusplus: true */

// Declare variables outside the scope of a function
var input;

function readInput() {
    "use strict";

    input = document.getElementById('input').value;
}

function printNumbersFrom1ToNNotDivisibleBy3And7() {
    "use strict";

    var i, result = '';

    for (i = 0; i < input; i += 1) {
        if (i % 3 !== 0 && i % 7 !== 0) {
            result += (i + 1) + '<br />';
        }
    }

    document.getElementById('result').innerHTML = result;
}

function validateInput() {
    "use strict";

    input = parseFloat(input);

    if (typeof input === 'number' && !isNaN(input)) {
        printNumbersFrom1ToNNotDivisibleBy3And7();
    } else {
        document.getElementById('result').innerHTML = 'Incorrect input!';
    }
}