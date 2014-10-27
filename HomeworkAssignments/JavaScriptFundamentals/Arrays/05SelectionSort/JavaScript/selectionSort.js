/*global document: false */

// Declare variables outside the scope of a function
var input, inputToArray = [];

function readInput() {
    "use strict";

    input = document.getElementById('input').value;
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

function selectionSort() {
    "use strict";

    var i, j, result = '', iMin;

    // Selection sort as in wikipedia
    /* a[0] to a[n-1] is the array to sort */
    /* advance the position through the entire array */
    /*   (could do j < n-1 because single element is also min element) */
    for (j = 0; j < inputToArray.length - 1; j += 1) {
        /* find the min element in the unsorted a[j .. n-1] */
        /* assume the min is the first element */
        iMin = j;

        /* test against elements after j to find the smallest */
        for (i = j + 1; i < inputToArray.length; i += 1) {
            /* if this element is less, then it is the new minimum */
            if (inputToArray[i] < inputToArray[iMin]) {
                /* found new minimum; remember its index */
                iMin = i;
            }
        }

        /* iMin is the index of the minimum element */
        /* Swap it with the current position if the index of 
         * the smallest element is not already equal to the current index (j) 
         */
        if (iMin !== j) {
            swap(j, iMin);
        }
    }

    result = inputToArray.join(', ');
    document.getElementById('result').innerHTML = 'Voila, the array is sorted: ' + result;
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

    if (valid) {
        selectionSort();
    } else {
        document.getElementById('result').innerHTML = 'Incorrect input!';
    }
}