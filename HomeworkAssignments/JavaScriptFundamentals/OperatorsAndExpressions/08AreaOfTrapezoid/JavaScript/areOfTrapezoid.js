/*global document: false */

var sideA, sideB, height;

function readInput() {
    "use strict";

    sideA = document.getElementById('side-a').value;
    sideB = document.getElementById('side-b').value;
    height = document.getElementById('height').value;
}

function areaOfTrapezoid() {
    "use strict";

    var area;
    sideA = parseFloat(sideA);
    sideB = parseFloat(sideB);
    height = parseFloat(height);

    // Validate input
    if ((typeof sideA === 'number' && !isNaN(sideA)) && (typeof sideB === 'number' && !isNaN(sideB)) &&
            (typeof height === 'number' && !isNaN(height)) && (sideA > 0 && sideB > 0 && height > 0)) {
        area = ((sideA + sideB) / 2) * height;

        document.getElementById('result').innerHTML = 'Trapezoid with sides: ' + sideA + ', ' + sideB + ' and height: ' + height + ' has an area: ' + area;
    } else {
        document.getElementById('result').innerHTML = 'Incorrect input!';
    }
}