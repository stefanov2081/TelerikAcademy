/*global document: false */

var number, index;

function readInput() {
    "use strict";

    number = document.getElementById('number').value;
    index = document.getElementById('index').value;
}

function getBitAtPosition() {
    "use strict";

    var bit;
    number = parseFloat(number);
    index = parseFloat(index);

    // Validate input
    if ((typeof number === 'number' && !isNaN(number)) && (typeof index === 'number' && !isNaN(index)) && (number >= 0 && index >= 0)) {
        // JS Lint complains about this... I don't know how to write it otherwise, if you have suggestions, I am all ears :)
        bit = (number & (1 << index));
        bit = bit >> index;

        document.getElementById('result').innerHTML = 'Bit at position ' + index + ' is: ' + bit;
    } else {
        document.getElementById('result').innerHTML = 'Incorrect input!';
    }
}