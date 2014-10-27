/*global document: false */

//function readInput(elementId) {
//    "use strict";

//    var input = document.getElementById(elementId).value;

//    return input;
//}

//function validateInput(input) {
//    "use strict";

//    input = parseFloat(input);

//    if (input % 1 === 0) {
//        if (typeof input === 'number' && !isNaN(input)) {
//            return input;
//        }
//    }

//    return 'Incorrect input!';
//}

function print(elementId, message) {
    "use strict";

    document.getElementById(elementId).innerHTML = message;
}

function generateList(arrayOfObjects, htmlSource) {
    "use strict";

    var i, j, lenght, property, currentProperty, sourceArrayClean = [], htmlSourceArray = htmlSource.split(' '), template = htmlSource;

    // Remove empty entries
    for (i = 0; i < htmlSourceArray.length; i += 1) {
        if (htmlSourceArray[i] !== '' && i > 0) {
            sourceArrayClean.push(htmlSourceArray[i]);
        }
    }

    // Create as many elements as there are objects
    lenght = sourceArrayClean.length;
    for (i = 0; i < arrayOfObjects.length - 1; i += 1) {

        for (var j = 0; j < lenght; j++) {
            sourceArrayClean.push(sourceArrayClean[j]);
        }
    }

    j = 0;

    for (i = 0; i < arrayOfObjects.length; i += 1) {

        for (property in arrayOfObjects[i]) {
            if (arrayOfObjects[i].hasOwnProperty(property)) {
                currentProperty = arrayOfObjects[i][property];

                sourceArrayClean[j] = '<li>' + sourceArrayClean[j];
                sourceArrayClean[j] = sourceArrayClean[j].replace(new RegExp('-{' + property + '}-'), currentProperty);
                sourceArrayClean[j] += '</li>';

                j += 1;
            }
        }
    }

    sourceArrayClean[0] = '<ul>' + sourceArrayClean[0];
    sourceArrayClean[sourceArrayClean.length - 1] += '</ ul>';

    return sourceArrayClean;
}

function main() {
    "use strict";

    var source, peopleList, result = [], i, people = [{ name: 'Peter', age: 14 }, { name: 'Gosho', age: 32 }, {name: 'Onufrii', age: 74}];
    //source = document.getElementById('list-item').getElementsByTagName('*');
    source = document.getElementById('list-item').innerHTML;

    peopleList = generateList(people, source);

    for (i = 0; i < peopleList.length; i += 1) {
        result += peopleList[i];
    }

    print('list-item', result);
}