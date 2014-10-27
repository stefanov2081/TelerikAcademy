/*global document: false */
/*jslint plusplus: true */

var getInput = [], numbers = [];

function readInput() {
    "use strict";

    var i;
    for (i = 0; i < 5; i++) {
        getInput.pop();
    }

    getInput.push(document.getElementById('value1').value);
    getInput.push(document.getElementById('value2').value);
    getInput.push(document.getElementById('value3').value);
    getInput.push(document.getElementById('value4').value);
    getInput.push(document.getElementById('value5').value);
}

// I am too lazy to write so many conditional statements...
function findGreatestNumber() {
    "use strict";

    var i, j, swapPlaces;

    // Sort the array in ascending order... First value would be the greatest
    for (i = 0; i < numbers.length; i++) {
        for (j = i + 1; j < numbers.length; j++) {
            if (numbers[j] > numbers[i]) {
                swapPlaces = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = swapPlaces;
            }
        }
    }

    document.getElementById('result').innerHTML = 'Greatest number is: ' + numbers[0];
}

function validateInput() {
    "use strict";

    numbers[0] = parseFloat(getInput[0]);
    numbers[1] = parseFloat(getInput[1]);
    numbers[2] = parseFloat(getInput[2]);
    numbers[3] = parseFloat(getInput[3]);
    numbers[4] = parseFloat(getInput[4]);

    if ((typeof numbers[0] === 'number' && !isNaN(numbers[0])) && (typeof numbers[1] === 'number' && !isNaN(numbers[1])) &&
            (typeof numbers[2] === 'number' && !isNaN(numbers[2])) && (typeof numbers[3] === 'number' && !isNaN(numbers[3])) &&
            (typeof numbers[4] === 'number' && !isNaN(numbers[4]))) {
        findGreatestNumber();
    } else {
        document.getElementById('result').innerHTML = 'Incorrect input!';
    }
}