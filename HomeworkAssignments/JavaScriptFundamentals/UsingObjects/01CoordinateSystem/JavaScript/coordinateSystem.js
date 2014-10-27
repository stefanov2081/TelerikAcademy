/*global document: false */
/*global location: false */

// I wanted to experiment with dynamic HTML. It was a bad idea... sorry for "the spagheti" code, I'll try to comment it
var pointsArray = [], linesArray = [];

// Point and line constructors
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

function lineCostructor(pX1, pY1, pX2, pY2) {
    "use strict";

    return {
        p1: pointCostructor(pX1, pY1),
        p2: pointCostructor(pX2, pY2),
        toString: function () {
            return 'L: ' + '(P1:' + this.p1.toString() + 'P2:' + this.p2.toString() + ')';
        }
    };
}

// Some functions to read and validate input
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

// Functions for manipulating the DOM
function print(elementId, message) {
    "use strict";

    document.getElementById(elementId).innerHTML = message;
}

function clearDomElement(elementId) {
    "use strict";

    document.getElementById(elementId).innerHTML = '';
}

// Creates an HTML element. It is overloaded and it allows for the creation of various elements
function generateDomElements(containerId, elementTagName, elementId, elementType, numberOfElements, optionalText, optionalOnClick) {
    "use strict";

    var i, domElement;

    if (optionalText === undefined) {
        for (i = 0; i < numberOfElements; i += 1) {
            domElement = document.createElement(elementTagName);
            domElement.type = elementType;
            domElement.id = (elementId + i);
            document.getElementById(containerId).appendChild(domElement);
        }
    } else if (optionalOnClick === undefined) {
        for (i = 0; i < numberOfElements; i += 1) {
            domElement = document.createElement(elementTagName);
            domElement.type = elementType;
            domElement.id = (elementId + i);
            domElement.textContent = optionalText;
            document.getElementById(containerId).appendChild(domElement);
        }
    } else {
        for (i = 0; i < numberOfElements; i += 1) {
            domElement = document.createElement(elementTagName);
            domElement.type = elementType;
            domElement.id = (elementId + i);
            domElement.textContent = optionalText;
            domElement.onclick = optionalOnClick;
            //domElement.addEventListener('click', clearDomElement('main-container'), false); // This works too, I am leaving it for refence

            document.getElementById(containerId).appendChild(domElement);
        }
    }
}

// Math stuff
// This function is overloaded
function calculateDistanceBetweenAllPointsInArray(arrayWithPoints, overloaded) {
    "use strict";

    var i, j, distanceArray = [], distance, result;

    if (overloaded === undefined) {
        for (i = 0; i < arrayWithPoints.length; i += 1) {
            if (i < arrayWithPoints.length - 1) {
                result = '(P' + i + ' ' + arrayWithPoints[i].toString() + ') is located:';
            }

            for (j = i + 1; j < arrayWithPoints.length; j += 1) {
                distance = ((arrayWithPoints[i].x - arrayWithPoints[j].x) * (arrayWithPoints[i].x - arrayWithPoints[j].x)) +
                    ((arrayWithPoints[i].y - arrayWithPoints[j].y) * (arrayWithPoints[i].y - arrayWithPoints[j].y));
                distance = Math.sqrt(distance);
                result += distance + ' units away from ' + '(P' + j + ' ' + arrayWithPoints[j].toString() + '),';
            }

            if (i < arrayWithPoints.length - 1) {
                result = result.substring(0, result.length - 1);
                result += ';';
                distanceArray.push(result);
            }
        }

        return distanceArray;
    }

    // No need for else
    for (i = 0; i < arrayWithPoints.length; i += 1) {
        for (j = i + 1; j < arrayWithPoints.length; j += 1) {
            distance = ((arrayWithPoints[i].x - arrayWithPoints[j].x) * (arrayWithPoints[i].x - arrayWithPoints[j].x)) +
                ((arrayWithPoints[i].y - arrayWithPoints[j].y) * (arrayWithPoints[i].y - arrayWithPoints[j].y));
            distance = Math.sqrt(distance);
        }

    }

    return distance;
}

function checkIfThreeLinesCanFormATriangle(arrayWithLines) {
    "use strict";

    var i, j, k, lineLength = [], swapPlaces;

    for (i = 0; i < arrayWithLines.length; i += 1) {
        pointsArray.push(arrayWithLines[i].p1);
        pointsArray.push(arrayWithLines[i].p2);
        lineLength.push(calculateDistanceBetweenAllPointsInArray(pointsArray, 'overloaded'));
        pointsArray = [];
    }

    // Sort the array in ascending order... First value would be the greatest
    for (i = 0; i < lineLength.length; i += 1) {
        for (j = i + 1; j < lineLength.length; j += 1) {
            if (lineLength[j] > lineLength[i]) {
                swapPlaces = lineLength[i];
                lineLength[i] = lineLength[j];
                lineLength[j] = swapPlaces;
            }
        }
    }

    // If longest line is shorter than any other two lines combine => can form a triangle
    for (i = 0; i < lineLength.length; i += 1) {
        for (j = i + 1; j < lineLength.length; j += 1) {
            for (k = j + 1; k < lineLength.length; k += 1) {
                if (lineLength[i] > (lineLength[j] + lineLength[k])) {
                    return 'Given lines can not form a triangle!';
                }
            }
        }
    }

    return 'Given lines can form a triangle!';

}

// Points
// Generate UI after the points have been created
function userUiAfterPointsCreation() {
    "use strict";

    var i, distanceArray;

    clearDomElement('main-container');
    generateDomElements('main-container', 'p', 'confirmation', undefined, 1, '');

    if (pointsArray.length <= 1) {
        print('confirmation0', pointsArray.length + ' point has been successfully created! It is now safely stored in your memory.');
    } else {
        print('confirmation0', pointsArray.length + ' points have been successfully created! They are now safely stored in your memory.');
    }

    for (i = 0; i < pointsArray.length; i += 1) {
        generateDomElements('main-container', 'p', 'para' + i, undefined, 1, 'P' + (i + 1) + ' ' + pointsArray[i].toString());
    }

    if (pointsArray.length > 1) {
        generateDomElements('main-container', 'p', 'result', undefined, 1,
            'Distance between ' + pointsArray.length +
            ' points has been calculated. Each distance is as follows:');
        distanceArray = calculateDistanceBetweenAllPointsInArray(pointsArray);

        for (i = 0; i < distanceArray.length; i += 1) {
            generateDomElements('main-container', 'p', 'point' + i, undefined, 1, distanceArray[i]);
        }
    } else {
        generateDomElements('main-container', 'p', 'result', undefined, 1,
            'There is only ' + pointsArray.length +
            ' point. In order to calculate the distance between two points you will need to create at least one more point.');
    }

    generateDomElements('main-container', 'button', 'back', undefined, 1, 'Back', function () { location.reload(); });
}

// Get the coordinates of each point, and instantiate points
function getPointsCoordinates() {
    "use strict";

    var i, j, coordinates, length = document.getElementsByTagName('input').length;

    for (i = 0; i < length; i += 1) {
        coordinates = readInput('input' + i);
        coordinates = coordinates.split(',');

        for (j = 0; j < coordinates.length; j += 1) {
            coordinates[j] = validateInput(coordinates[j]);
        }

        if (coordinates[i] !== 'Incorrect input!') {
            pointsArray.push(pointCostructor(coordinates[0], coordinates[coordinates.length - 1]));
        } else {
            print('result0', 'Incorrect input!');
        }
    }

    document.querySelector('button').onclick = userUiAfterPointsCreation();
}

// Generate UI with input fields, to get the coordinates of the points to be created
function generateUiForPointsInput() {
    "use strict";

    var numberOfInputFields = readInput('input0');
    numberOfInputFields = validateInput(numberOfInputFields);
    generateDomElements('main-container', 'p', 'result', undefined, 1, '');

    if (numberOfInputFields !== 'Incorrect input!') {
        clearDomElement('main-container');
        generateDomElements('main-container', 'p', 'paragraph', undefined, 1,
            'Each input represents a point. Enter coordinates of a point separated by comma (,)' +
            ' Example: x, y ... i.e. 1, 1');
        generateDomElements('main-container', 'input', 'input', 'text', numberOfInputFields);
        generateDomElements('main-container', 'button', 'submit-button', undefined, 1, 'Submit', function () { getPointsCoordinates(); });

    } else {
        print('result0', 'Incorrect input!');
    }
}

// Generate UI with one input field, to get the number of points to be created
function generateUiToGetNumberOfPoints() {
    "use strict";

    generateDomElements('main-container', 'p', 'paragraph', undefined, 1, 'You have choosen to manipulate points, splendid!');
    generateDomElements('main-container', 'p', 'paragraph2', undefined, 1, 'Please enter how many points would you like to create?');
    generateDomElements('main-container', 'input', 'input', 'text', 1);
    generateDomElements('main-container', 'button', 'submit-button', undefined, 1, 'Submit', function () { generateUiForPointsInput(); });
}

// Lines
// Generate UI after the lines have been created
function userUiAfterLinesCreation() {
    "use strict";

    var i, canFormTriangle;

    clearDomElement('main-container');
    generateDomElements('main-container', 'p', 'confirmation', undefined, 1, '');

    if (linesArray.length <= 1) {
        print('confirmation0', linesArray.length + ' line has been successfully created! It is now safely stored in your memory.');
    } else {
        print('confirmation0', linesArray.length + ' lines have been successfully created! They are now safely stored in your memory.');
    }

    for (i = 0; i < linesArray.length; i += 1) {
        generateDomElements('main-container', 'p', 'para' + i, undefined, 1, 'L' + (i + 1) + ' ' + linesArray[i].toString() + '; ');
    }

    if (linesArray.length > 2) {
        generateDomElements('main-container', 'p', 'result', undefined, 1,
            'Distance between ' + linesArray.length +
            ' lines has been calculated.');
        canFormTriangle = checkIfThreeLinesCanFormATriangle(linesArray);

        generateDomElements('main-container', 'p', 'line' + i, undefined, 1, canFormTriangle);
    } else if (linesArray.length === 1) {
        generateDomElements('main-container', 'p', 'result', undefined, 1,
            'There is only ' + linesArray.length +
            ' line. In order to calculate if three lines can form a triangle you will need two more lines.');
    } else {
        generateDomElements('main-container', 'p', 'result', undefined, 1,
            'There are only ' + linesArray.length +
            ' lines. In order to calculate if three lines can form a triangle you will need one more line.');
    }

    generateDomElements('main-container', 'button', 'submit-button', undefined, 1, 'Back', function () { location.reload(); });
}

// Get the coordinates of each point creating a line, and instantiate lines
function getLinesCoordinates() {
    "use strict";

    var i, j, coordinates, length = document.getElementsByTagName('input').length;

    for (i = 0; i < length; i += 1) {
        coordinates = readInput('input' + i);
        coordinates = coordinates.split(',');

        for (j = 0; j < coordinates.length; j += 1) {
            coordinates[j] = validateInput(coordinates[j]);
        }

        if (coordinates[i] !== 'Incorrect input!') {
            linesArray.push(lineCostructor(coordinates[0], coordinates[1], coordinates[2], coordinates[3]));
        } else {
            print('result0', 'Incorrect input!');
        }
    }

    document.querySelector('button').onclick = userUiAfterLinesCreation();
}

// Generate UI with input fields, to get the coordinates of the points, that make up a line
function generateUiForLinesInput() {
    "use strict";

    var numberOfInputFields = readInput('input0');
    numberOfInputFields = validateInput(numberOfInputFields);
    generateDomElements('main-container', 'p', 'result', undefined, 1, '');

    if (numberOfInputFields !== 'Incorrect input!') {
        clearDomElement('main-container');
        generateDomElements('main-container', 'p', 'paragraph', undefined, 1,
            'Each input represents a line. Enter coordinates of a line represented by two points separated by comma (,)' +
            ' Example: x1, y1, x2, y2 ... i.e. 1, 1, 2, 2');
        generateDomElements('main-container', 'input', 'input', 'text', numberOfInputFields);
        generateDomElements('main-container', 'button', 'submit-button', undefined, 1, 'Submit', function () { getLinesCoordinates(); });

    } else {
        print('result0', 'Incorrect input!');
    }
}

// Generate UI with one input field, to get the number of points to be created
function generateUiToGetNumberOfLines() {
    "use strict";

    generateDomElements('main-container', 'p', 'paragraph', undefined, 1, 'You have choosen to manipulate lines, splendid!');
    generateDomElements('main-container', 'p', 'paragraph2', undefined, 1, 'Please enter how many lines would you like to create?');
    generateDomElements('main-container', 'input', 'input', 'text', 1);
    generateDomElements('main-container', 'button', 'submit-button', undefined, 1, 'Submit', function () { generateUiForLinesInput(); });
}

// Choose point or line depending on user's choice
function proccessUserChoice() {
    "use strict";

    if (document.getElementById('point').checked) {
        clearDomElement('main-container');
        generateUiToGetNumberOfPoints();
    } else if (document.getElementById('line').checked) {
        clearDomElement('main-container');
        generateUiToGetNumberOfLines();
    } else {
        print('Come on now don not be so picky. You have only two values to choose from... Choose points or lines... Imagine if I had put !100 radio buttons?');
    }
}

function main() {
    "use strict";

    proccessUserChoice();
}