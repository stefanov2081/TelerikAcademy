/*global document: false */

var value1, value2;

function readInput() {
    "use strict";

    value1 = document.getElementById('value1').value;
    value2 = document.getElementById('value2').value;
}

// Swap values if first is greater than second
function swapIfFirstIsGreater() {
    "use strict";

    if (value1 > value2) {
        var temp = value1;
        value1 = value2;
        value2 = temp;

        document.getElementById('result').innerHTML = 'Values swapped!<br /> Value 1: ' + value1 + ', Value 2: ' + value2;
    } else if (value1 === value2) {
        document.getElementById('result').innerHTML = 'The two values are equal... Nothing happens!';
    } else {
        document.getElementById('result').innerHTML = 'First value is smaller than the second... Nothing happens!';
    }
}

function validateInput() {
    "use strict";

    value1 = parseFloat(value1);
    value2 = parseFloat(value2);

    if ((typeof value1 === 'number' && !isNaN(value1)) && (typeof value2 === 'number' && !isNaN(value2))) {
        swapIfFirstIsGreater();
    } else {
        document.getElementById('result').innerHTML = 'Incorrect input!';
    }
}