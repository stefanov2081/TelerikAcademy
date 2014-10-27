/*global document: false */

var number;

function readInput() {
    "use strict";

    number = document.getElementById('number').value;
}

function isNPrime() {
    "use strict";

    var prime = true, i;
    number = parseFloat(number);

    // Validate input
    if (typeof number === 'number' && !isNaN(number)) {
        for (i = 2; i < number / 2 + 1; i += 1) {
            if (number % i === 0) {
                prime = false;
            }
        }

        if (prime) {
            document.getElementById('result').innerHTML = number + ' is prime!';
        } else {
            document.getElementById('result').innerHTML = number + ' is NOT prime!';
        }
    } else {
        document.getElementById('result').innerHTML = 'Incorrect input!';
    }
}