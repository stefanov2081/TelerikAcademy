/*global document: false */

// Declare variables outside the scope of a function
var input;

function readInput() {
    "use strict";

    input = document.getElementById('input').value;
}

function printNumberFrom1ToN() {
    "use strict";

    var i, result = '';

    for (i = 0; i < input; i += 1) {
        result += (i + 1) + '<br />';
    }

    document.getElementById('result').innerHTML = result;
}

function validateInput() {
    "use strict";

    input = parseFloat(input);

    if (typeof input === 'number' && !isNaN(input)) {
        printNumberFrom1ToN();
    } else {
        document.getElementById('result').innerHTML = 'Incorrect input!';
    }
}