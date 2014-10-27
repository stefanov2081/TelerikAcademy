/*global document: false */

var value1, value2, value3;

function readInput() {
    "use strict";

    value1 = document.getElementById('value1').value;
    value2 = document.getElementById('value2').value;
    value3 = document.getElementById('value3').value;
}

function sortThreeValuesDesc() {
    "use strict";

    if (value1 > value2 && value2 > value3) {
        document.getElementById('result').innerHTML = 'Sorted in descending order:<br />' + value1 + '<br />' + value2 + '<br />' + value3 + '<br />';
    } else if (value1 > value3 && value3 > value2) {
        document.getElementById('result').innerHTML = 'Sorted in descending order:<br />' + value1 + '<br />' + value3 + '<br />' + value2 + '<br />';
    } else if (value2 > value1 && value1 > value3) {
        document.getElementById('result').innerHTML = 'Sorted in descending order:<br />' + value2 + '<br />' + value1 + '<br />' + value3 + '<br />';
    } else if (value2 > value3 && value3 > value1) {
        document.getElementById('result').innerHTML = 'Sorted in descending order:<br />' + value2 + '<br />' + value3 + '<br />' + value1 + '<br />';
    } else if (value3 > value1 && value1 > value2) {
        document.getElementById('result').innerHTML = 'Sorted in descending order:<br />' + value3 + '<br />' + value1 + '<br />' + value2 + '<br />';
    } else if (value3 > value2 && value2 > value1) {
        document.getElementById('result').innerHTML = 'Sorted in descending order:<br />' + value3 + '<br />' + value2 + '<br />' + value1 + '<br />';
    } else {
        document.getElementById('result').innerHTML = 'All values are equal';
    }
}

function validateInput() {
    "use strict";

    value1 = parseFloat(value1);
    value2 = parseFloat(value2);
    value3 = parseFloat(value3);

    if ((typeof value1 === 'number' && !isNaN(value1)) && (typeof value2 === 'number' && !isNaN(value2)) && (typeof value3 === 'number' && !isNaN(value3))) {
        sortThreeValuesDesc();
    } else {
        document.getElementById('result').innerHTML = 'Incorrect input!';
    }
}