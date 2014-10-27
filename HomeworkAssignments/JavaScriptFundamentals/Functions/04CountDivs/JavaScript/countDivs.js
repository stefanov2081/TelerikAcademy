/*global document: false */

function countHhtmlObjects(tagName) {
    "use strict";

    var count = document.getElementsByTagName(tagName)

    return count.length;
}

function print(message) {
    "use strict";

    var count = document.getElementById('result').innerHTML = message;
}

function main() {
    "use strict";

    var result = countHhtmlObjects('div');
    print('There is/are ' + result + ' div element/s');
}