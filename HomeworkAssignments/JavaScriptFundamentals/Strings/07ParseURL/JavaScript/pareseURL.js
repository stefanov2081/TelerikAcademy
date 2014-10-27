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

function parseURL(url) {
    "use strict";

    var protocol = '', server = '', resources = '', i, readingProtocol = false, readingServer = false,
        currentSubstring = '', currentSymbol;

    if (url !== '' && url !== ' ') {
        for (i = 0; i < url.length; i += 1) {
            currentSymbol = url[i]
            currentSubstring += currentSymbol;

            if (currentSymbol === '/' && url[i + 1] === '/') {
                readingProtocol = true;
                continue;
            } else if (readingProtocol) {
                protocol = currentSubstring;
                currentSubstring = '';
                readingProtocol = false;
                readingServer = true;
            } else if (currentSymbol === '/' && readingServer) {
                server = currentSubstring.substr(0, currentSubstring.length - 1);
                resources = url.substr(protocol.length + server.length);
                break;
            }
        }

        return {
            protocol: protocol,
            server: server,
            resources: resources

        };
    }

    return 'Invalid URL';
}

function main() {
    "use strict";

    var input = readInput('input'), result;
    result = parseURL(input);

    if (result === 'Ivalid URL') {
        print('result', result);
    } else {
        print('result', 'Protocol: ' + result.protocol + '<br />Server: ' + result.server + '<br />Resources: ' + result.resources);
    }

}