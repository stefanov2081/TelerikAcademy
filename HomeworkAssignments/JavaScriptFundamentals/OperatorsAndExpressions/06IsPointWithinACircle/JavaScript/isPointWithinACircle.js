/*global document: false */

var radius, posX, posY;

function readInput() {
    "use strict";

    radius = document.getElementById('radius').value;
    posX = document.getElementById('x-coordinate').value;
    posY = document.getElementById('y-coordinate').value;
}

// Find if a point is within a circle
function withinCircle() {
    "use strict";

    radius = parseFloat(radius);
    posX = parseFloat(posX);
    posY = parseFloat(posY);

    if ((typeof radius === 'number' && !isNaN(radius)) && (typeof posX === 'number' && !isNaN(posX)) && (typeof posY === 'number' && !isNaN(posY))) {

        // Find the distance between the point and the center of the circle
        var distance = (posX * posX) + (posY * posY);
        radius = radius * radius;

        if (distance < radius) {
            document.getElementById('result').innerHTML = 'The point lies within the circle.';
        } else if (distance === radius) {
            document.getElementById('result').innerHTML = 'The point lies on the circumference of the circle.';
        } else {
            document.getElementById('result').innerHTML = 'The point lies outside of the circle.';
        }
    } else {
        document.getElementById('result').innerHTML = 'Incorrect input!';
    }
}