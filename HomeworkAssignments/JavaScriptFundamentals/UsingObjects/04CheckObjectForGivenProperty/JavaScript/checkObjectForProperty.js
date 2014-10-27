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

function hasProperty(obj, property) {
    "use strict";

    var attr;

    if (null === obj || "object" !== typeof obj) {
        return obj;
    }

    for (attr in obj) {
        if (obj.hasOwnProperty(attr)) {
            if (attr === property) {
                return 'There is such property: ' + attr;
            }
        }
    }

    return 'No such property';
}

function main() {
    "use strict";

    var point = pointCostructor(1, 1), property, result;
    point.WhyAreYouSoLazy = 'You are lazy!';
    property = readInput('property');
    result = hasProperty(point, property);

    print('more-info', 'Searching...');
    print('result', 'Point has these properties: ' + point.toString() + 'Let us see if the point has the property that you are searching for:  ' + result);
}