/*global document: false */

function readInput(elementId) {
    "use strict";

    var input = document.getElementById(elementId).value;

    return input;
}

function validateInput(input) {
    "use strict";

    if (typeof input === 'string' && isNaN(input)) {
        return input;
    }

    return 'Incorrect input!';
}

function countOccurrences(text, keyCaseInsensitive, keyCaseSensitive) {
    "use strict";

    // My regex splits the array with empty strings, if you know how to remove the empty strings please advise me
    var i, count = 0, textToArray;

    if (keyCaseInsensitive !== undefined) {
        keyCaseInsensitive = keyCaseInsensitive.toLowerCase();
        text = text.toLowerCase();
        textToArray = text.split(/[,|, |.|. | |?:|!|...]/);

        for (i = 0; i < textToArray.length; i += 1) {
            if (textToArray[i] === keyCaseInsensitive) {
                count += 1;
            }
        }
    } else if (keyCaseSensitive !== undefined) {
        textToArray = text.split(/[,|, |.|. | |?:|!|...]/);

        for (i = 0; i < textToArray.length; i += 1) {
            if (textToArray[i] === keyCaseSensitive) {
                count += 1;
            }
        }
    }

    return count;
}

function print(message) {
    "use strict";

    document.getElementById('result').innerHTML = message;
}

function triggerOn() {
    "use strict";

    document.getElementById('case-sens').value = 'on';
}

function main() {
    "use strict";

    var text, key, searchParam, result;
    text = readInput('text');
    key = readInput('key');
    searchParam = readInput('case-sens');
    text = validateInput(text);
    key = validateInput(key);

    if (text !== 'Incorrect input!' && key !== 'Incorrect input!') {
        if (searchParam === 'off') {
            result = countOccurrences(text, key);
            print(key + ' appears ' + result + ' times');
        } else if (searchParam === 'on') {
            result = countOccurrences(text, undefined, key);
            print(key + ' appears ' + result + ' times');
        }
    } else {
        print('Incorrect input!');

    }
}
