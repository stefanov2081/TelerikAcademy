/*global document: false */

var width, height;

function readInput() {
    "use strict";
    width = document.getElementById('width').value;
    height = document.getElementById('height').value;
}

function areaOfRectangle() {
    "use strict";
    width = parseFloat(width);
    height = parseFloat(height);

    // Validate input
    if ((typeof width === 'number' && !isNaN(width)) && (typeof height === 'number' && !isNaN(height)) && (width > 0 && height > 0)) {
        var area = width * height;
        document.getElementById('result').innerHTML = 'The are of the rectangle is ' + area;
    } else {
        document.getElementById('result').innerHTML = 'Incorrect input!';
    }
}