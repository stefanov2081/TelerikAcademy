/*global document: false */
/*jslint plusplus: true */

var input, inputLength;

function readInput() {
    "use strict";

    input = document.getElementById('input').value;
    inputLength = input;
}

// Read number and print it's "name"... I know that I could have done this in a better way, so I am complementing with style...
// I shouldn't work as a designer though xD
function nameOfNumber() {
    "use strict";

    var result = '', lastDigit = input % 10, i, current;

    for (i = 0; i < inputLength.length; i++) {
        current = input % 10;
        input = Math.floor(input / 10);

        switch (current) {
        case 0:
            if (inputLength.length === 1) {
                result = 'zero';
            }
            break;
        case 1:
            if (i === 0) {
                result = 'one';
            } else if (i === 1) {
                switch (lastDigit) {
                case 0:
                    result = 'ten';
                    break;
                case 1:
                    result = 'eleven';
                    break;
                case 2:
                    result = 'twelve';
                    break;
                case 3:
                    result = 'thirteen';
                    break;
                case 4:
                    result = 'fourteen';
                    break;
                case 5:
                    result = 'fifteen';
                    break;
                case 6:
                    result = 'sixteen';
                    break;
                case 7:
                    result = 'seventeen';
                    break;
                case 8:
                    result = 'eightenn';
                    break;
                case 9:
                    result = 'nineteen';
                    break;
                default:
                    result = 'I am sorry, I don not know what is that.';
                }
            } else if (i === 2) {
                result = 'One hundred ' + result;
            }

            break;
        case 2:
            if (i === 0) {
                result = 'two';
            } else if (i === 1) {
                result = 'twenty ' + result;
            } else if (i === 2) {
                result = 'Two hundred ' + result;
            }
            break;
        case 3:
            if (i === 0) {
                result = 'three';
            } else if (i === 1) {
                result = 'thirty ' + result;
            } else if (i === 2) {
                result = 'Three hundred ' + result;
            }
            break;
        case 4:
            if (i === 0) {
                result = 'four';
            } else if (i === 1) {
                result = 'forty ' + result;
            } else if (i === 2) {
                result = 'Four hundred ' + result;
            }
            break;
        case 5:
            if (i === 0) {
                result = 'five';
            } else if (i === 1) {
                result = 'fifty ' + result;
            } else if (i === 2) {
                result = 'Five hundred ' + result;
            }
            break;
        case 6:
            if (i === 0) {
                result = 'six';
            } else if (i === 1) {
                result = 'sixty ' + result;
            } else if (i === 2) {
                result = 'Six hundred ' + result;
            }
            break;
        case 7:
            if (i === 0) {
                result = 'seven';
            } else if (i === 1) {
                result = 'seventy ' + result;
            } else if (i === 2) {
                result = 'Seven hundred ' + result;
            }
            break;
        case 8:
            if (i === 0) {
                result = 'eight';
            } else if (i === 1) {
                result = 'eighty ' + result;
            } else if (i === 2) {
                result = 'Eight hundred ' + result;
            }
            break;
        case 9:
            if (i === 0) {
                result = 'nine';
            } else if (i === 1) {
                result = 'ninety ' + result;
            } else if (i === 2) {
                result = 'Nine hundred ' + result;
            }
            break;
        default:
            result = 'I can only count to 999 :(';
            break;
        }
    }

    document.getElementById('result').innerHTML = result;
}

function validateInput() {
    "use strict";

    input = parseFloat(input);

    if (typeof input === 'number' && !isNaN(input)) {
        if (inputLength.length <= 3) {
            nameOfNumber();
        } else {
            document.getElementById('result').innerHTML = 'Try with smaller number!';
        }
    } else {
        document.getElementById('result').innerHTML = 'Incorrect input!';
    }
}