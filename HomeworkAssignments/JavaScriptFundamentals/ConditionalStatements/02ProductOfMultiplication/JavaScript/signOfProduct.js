/*global document: false */

var value1, value2, value3;

function readInput() {
    "use strict";

    value1 = document.getElementById('value1').value;
    value2 = document.getElementById('value2').value;
    value3 = document.getElementById('value3').value;
}

// Find what would be the sign of multiplication
function signOfProduct() {
    "use strict";

    if ((value1 > 0 && value2 > 0 && value3 > 0) || (value1 < 0 && value2 < 0 && value3 > 0) ||
            (value1 > 0 && value2 < 0 && value3 < 0) || (value1 < 0 && value2 > 0 && value3 < 0)) {
        document.getElementById('result').innerHTML = 'The product of the multiplication will be positive!';
    } else if ((value1 < 0 && value2 > 0 && value3 > 0) || (value1 > 0 && value2 < 0 && value3 > 0) ||
            (value1 > 0 && value2 > 0 && value3 < 0) || (value1 < 0 && value2 < 0 && value3 < 0)) {
        document.getElementById('result').innerHTML = 'The product of the multiplication will be negative!';
    } else {
        document.getElementById('result').innerHTML = 'The product of the multiplication will be zero!';
    }
}

function validateInput() {
    "use strict";

    value1 = parseFloat(value1);
    value2 = parseFloat(value2);
    value3 = parseFloat(value3);

    if ((typeof value1 === 'number' && !isNaN(value1)) && (typeof value2 === 'number' && !isNaN(value2)) && (typeof value3 === 'number' && !isNaN(value3))) {
        signOfProduct();
    } else {
        document.getElementById('result').innerHTML = 'Incorrect input!';
    }
}