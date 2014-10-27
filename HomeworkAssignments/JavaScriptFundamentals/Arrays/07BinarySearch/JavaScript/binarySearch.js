/*global document: false */

// Declare variables outside the scope of a function
var input, inputToArray = [], key;

function readInput() {
    "use strict";

    input = document.getElementById('input').value;
    key = document.getElementById('key').value;
}

function splitInput() {
    "use strict";

    inputToArray = input.split(',');
}

function swap(i, j) {
    "use strict";

    var c = inputToArray[i];
    inputToArray[i] = inputToArray[j];
    inputToArray[j] = c;
}

function midPoint(iMin, iMax) {
    "use strict";

    return Math.floor((iMin + iMax) / 2);
}

function binarySearch(array, key, iMin, iMax) {
    "use strict";

    var iMid;

    // test if array is empty
    if (iMax < iMin) {
        // set is empty, so return value showing not found
        return -1;
    } else {
        // calculate midpoint to cut set in half
        iMid = midPoint(iMin, iMax);

        // three-way comparison
        if (array[iMid] > key) {
            // key is in lower subset
            return binarySearch(array, key, iMin, iMid - 1);
        } else if (array[iMid] < key) {
            // key is in upper subset
            return binarySearch(array, key, iMid + 1, iMax);
        } else {
            // key has been found
            document.getElementById('result').innerHTML = 'Number: ' + key + ' has an index of: ' + iMid;
            return iMid;
        }
    }
}

function validateInput() {
    "use strict";

    var i, valid = true;

    for (i = 0; i < inputToArray.length; i += 1) {
        inputToArray[i] = parseFloat(inputToArray[i]);

        if (typeof inputToArray[i] !== 'number' || isNaN(inputToArray[i])) {
            valid = false;
        }
    }

    key = parseFloat(key);

    if ((typeof key === 'number' && !isNaN(key)) && valid) {
        binarySearch(inputToArray, key, 0, inputToArray.length - 1);
    } else {
        document.getElementById('result').innerHTML = 'Incorrect input!';
    }
}