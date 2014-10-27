/*global document: false */

function readInput(elementId) {
    "use strict";

    var input = document.getElementById(elementId).value;

    return input;
}

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

String.prototype.replaceAt = function replaceAt(index, character) {
    "use strict";

    return this.substr(0, index) + character + this.substr(index + character.length);
};

function changeTextCasingAccordingToTags(text) {
    "use strict";

    var i, j, currentSymbol, currentCommand = '', readingCommand = false, startIndex, endIndex, searchingForClosingTag = false, random;

    if (text !== '' && ' ') {
        for (i = 0; i < text.length; i += 1) {
            currentSymbol = text[i];

            if (currentSymbol === '<' && !searchingForClosingTag) {
                readingCommand = true;
            } else if (readingCommand) {
                if (currentSymbol === '>') {
                    startIndex = i + 1;
                    readingCommand = false;
                    searchingForClosingTag = true;
                    continue;
                }

                currentCommand += text[i];
            } else if (searchingForClosingTag) {
                if (currentSymbol === '<') {
                    var a = text.substr(i, currentCommand.length + 3);
                    if (text.substr(i, currentCommand.length + 3) === ('</' + currentCommand + '>')) {
                        endIndex = i - 1;
                        searchingForClosingTag = false;
                    }
                }
            }

            if (currentCommand !== '' && !searchingForClosingTag && !readingCommand) {
                if (currentCommand === 'upcase') {
                    for (j = startIndex; j < endIndex; j += 1) {
                        text = text.replaceAt(j, text[j].toUpperCase());
                    }

                    currentCommand = '';
                } else if (currentCommand === 'lowcase') {
                    for (j = startIndex; j < endIndex; j += 1) {
                        text = text.replaceAt(j, text[j].toLowerCase());
                    }

                    currentCommand = '';
                } else if (currentCommand === 'mixcase') {
                    for (j = startIndex; j < endIndex; j += 1) {
                        random = Math.random();
                        if (random < 0.5) {
                            text = text.replaceAt(j, text[j].toUpperCase());
                        } else {
                            text = text.replaceAt(j, text[j].toLowerCase());
                        }
                    }

                    currentCommand = '';
                }
            }
        }

        return text;
    }

    return 'Input is empty';
}

function main() {
    "use strict";

    var textToPrint = 'We are &lt;mixcase&gt;living&lt;/mixcase&gt; in a &lt;upcase&gt;yellow submarine&lt;/upcase&gt;.' +
        ' We &lt;mixcase&gt;don\'t&lt;/mixcase&gt; have &lt;lowcase&gt;anything&lt;/lowcase&gt; else.',
        result, textToSearch = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>.' +
        ' We <mixcase>don\'t</mixcase> have <lowcase>anything</lowcase> else.';

    

    result = changeTextCasingAccordingToTags(textToSearch);
    print('more-info', textToPrint);
    print('result', 'The result is as follows: ' + result);
}

