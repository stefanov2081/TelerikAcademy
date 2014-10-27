/*global document: false */

var a, b, c;

function readInput() {
    "use strict";

    a = document.getElementById('a').value;
    b = document.getElementById('b').value;
    c = document.getElementById('c').value;
}

function solveQuadraticEquation() {
    "use strict";

    // Find discriminant
    var d = (b * b) - (4 * a * c), x1, x2;

    // If discriminant is less than zero => there are no real roots.
    if (d < 0) {
        document.getElementById('result').innerHTML = 'There are no real roots<br />x1 = Imaginary!<br /> x2 = Imaginary!';
    } else if (d > 0) {
        // If discriminant is greater than zero => calculate real roots.

        x1 = (-b + Math.sqrt(d) / 2 * a);
        x2 = (-b - Math.sqrt(d) / 2 * a);

        document.getElementById('result').innerHTML = 'x1 = ' + x1 + '<br />x2 = ' + x2;
    } else {
        // All other cases => calculate real roots. (if d = 0, two real roots are equal)

        x1 = -b / 2 * a;

        document.getElementById('result').innerHTML = 'x1 = ' + x1 + '<br />x2 = x1 = ' + x1;
    }

}

function validateInput() {
    "use strict";

    a = parseFloat(a);
    b = parseFloat(b);
    c = parseFloat(c);

    if ((typeof a === 'number' && !isNaN(a)) && (typeof b === 'number' && !isNaN(b)) && (typeof c === 'number' && !isNaN(c))) {
        solveQuadraticEquation();
    } else {
        document.getElementById('result').innerHTML = 'Incorrect input!';
    }
}