/*global document: false */

var input;

function readInput() {
    "use strict";

    input = document.getElementById('input').value;
}

function nameOfDigit() {
    "use strict";

    switch (input) {
    case 0:
        document.getElementById('result').innerHTML = 'Zero (Rei)';
        break;
    case 1:
        document.getElementById('result').innerHTML = 'One (Ichi)';
        break;
    case 2:
        document.getElementById('result').innerHTML = 'Two (Ni)';
        break;
    case 3:
        document.getElementById('result').innerHTML = 'Tree (San)';
        break;
    case 4:
        document.getElementById('result').innerHTML = 'Four (Shi)';
        break;
    case 5:
        document.getElementById('result').innerHTML = 'Five (Go)';
        break;
    case 6:
        document.getElementById('result').innerHTML = 'Six (Roku)';
        break;
    case 7:
        document.getElementById('result').innerHTML = 'Seven (Shichi)';
        break;
    case 8:
        document.getElementById('result').innerHTML = 'Eight (Hachi)';
        break;
    case 9:
        document.getElementById('result').innerHTML = 'Nine (Kyu)';
        break;
    default:
        document.getElementById('result').innerHTML = 'I can count only to nine :(';
        break;
    }
}

function validateInput() {
    "use strict";

    input = parseFloat(input);

    if (typeof input === 'number' && !isNaN(input)) {
        nameOfDigit();
    } else {
        document.getElementById('result').innerHTML = 'Incorrect input!';
    }
}