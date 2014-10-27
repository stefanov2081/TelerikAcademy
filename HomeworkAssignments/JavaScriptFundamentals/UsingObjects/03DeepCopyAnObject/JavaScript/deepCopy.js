/*global document: false */

function readInput(elementId) {
    "use strict";

    var input = document.getElementById(elementId).value;

    return input;
}

function validateInput(input) {
    "use strict";

    input = parseFloat(input);

    if (input % 1 === 0) {
        if (typeof input === 'number' && !isNaN(input)) {
            return input;
        }
    }

    return 'Incorrect input!';
}

function print(elementId, message) {
    "use strict";

    document.getElementById(elementId).innerHTML = message;
}

function pointCostructor(pX, pY) {
    "use strict";

    return {
        x: pX,
        y: pY,
        toString: function () {
            return 'X: ' + this.x + ', Y: ' + this.y + ';';
        }
    };
}

function clone(obj) {
    if (null === obj || "object" !== typeof obj) {
        return obj;
    }

    var copy = {};
    for (var attr in obj) {
        if (obj.hasOwnProperty(attr)) {
            copy[attr] = obj[attr]
        };
    }

    return copy;
}

function main() {
    "use strict";

    var point = pointCostructor(1, 1), clonedPoint;

    print('info', 'There is a point: ' + point.toString());
    print('more-info', 'Now the point is being copied')
    
    clonedPoint = clone(point);
    print('result', 'Now we have two points: ' + point.toString() + ' - original, and ' + clonedPoint.toString() + ' EVIL clone from hell!');
}