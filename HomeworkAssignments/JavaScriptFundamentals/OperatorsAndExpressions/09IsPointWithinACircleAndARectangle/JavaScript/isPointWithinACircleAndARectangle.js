/*global document: false */

var radius, posX, posY, valid = false;

function readInput() {
    "use strict";
    radius = document.getElementById('radius').value;
    posX = document.getElementById('x-coordinate').value;
    posY = document.getElementById('y-coordinate').value;
}

function validateInput() {
    "use strict";

    radius = parseFloat(radius);
    posX = parseFloat(posX);
    posY = parseFloat(posY);

    if ((typeof radius === 'number' && !isNaN(radius)) && (typeof posX === 'number' && !isNaN(posX)) &&
            (typeof posY === 'number' && !isNaN(posY))) {
        valid = true;
    }
}

// Find if a point is within a circle
function withinCircle() {
    "use strict";

    radius = parseFloat(radius);
    posX = parseFloat(posX);
    posY = parseFloat(posY);

    // Find the distance between the point and circle's center
    if (valid) {
        var distance = ((posX - 1) * (posX - 1)) + ((posY - 1) * (posY - 1));
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

// Find if a point is within a rectangle
function withinRectangle() {
    "use strict";

    if (valid) {
        // *uck JS Lint ...
        // In my opinion this is hard to read, but according to JS Lint this is the right way to format it...
        var width = 6, height = 2, rectX1 = -5, rectX2 = 1, rectX4 = -5, rectY1 = -1, rectY2 = -1, rectY4 = -3,
            xPrime = posX - rectX1, yPrime = posY - rectY1,
            isWithinWidth = (xPrime * ((rectX2 - rectX1) / width)) + (yPrime * ((rectY2 - rectY1) / height)),
            isWithinHeight = (xPrime * ((rectX4 - rectX1) / width)) + (yPrime * ((rectY4 - rectY1) / height));

        if ((isWithinWidth > 0 && isWithinWidth < width) && (isWithinHeight > 0 && isWithinHeight < height)) {
            document.getElementById('result2').innerHTML = 'The point lies within the rectangle.';
        } else if ((isWithinWidth === 0 && isWithinHeight >= 0 && isWithinHeight <= height) ||
                (isWithinWidth === width && isWithinHeight >= 0 && isWithinHeight <= height) ||
                (isWithinHeight === 0 && isWithinWidth >= 0 && isWithinWidth <= width) ||
                (isWithinHeight === height && isWithinWidth >= 0 && isWithinWidth <= width)) {
            document.getElementById('result2').innerHTML = 'The point lies on the rectangle.';
        } else {
            document.getElementById('result2').innerHTML = 'The point lies outside of the rectangle.';
        }
    }
}