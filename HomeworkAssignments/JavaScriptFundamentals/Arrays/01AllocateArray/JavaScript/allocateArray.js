/*global document: false */
/*jslint plusplus: true */

function allocateArray() {
    var array = [], i, result = '';

    for (i = 0; i < 20; i += 1) {
        array[i] = i * 5;
        result += array[i];

        if (i < 19) {
            result += ', ';
        }
    }

    document.getElementById('result').innerHTML = result;
}