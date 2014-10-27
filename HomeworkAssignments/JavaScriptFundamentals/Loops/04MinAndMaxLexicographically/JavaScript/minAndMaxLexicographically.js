/*global document: false */
/*global navigator: false */
/*global window: false */

function minAndMaxLexicographicalElement() {
    "use strict";
    var propertyName, propArray = [], result = '';

    for (propertyName in document) {
        if (document.hasOwnProperty(propertyName)) {
            propArray.push(propertyName);
        }
    }

    propArray.sort();
    result = 'Min lexicographical element from document: ' + propArray[0] + '<br />' +
        'Max lexicographical element from document: ' + propArray[propArray.length - 1] + '<br />';
    propArray = [];

    for (propertyName in window) {
        if (window.hasOwnProperty(propertyName)) {
            propArray.push(propertyName);
        }
    }

    propArray.sort();
    result += '<br />Min lexicographical element from window: ' + propArray[0] + '<br />' +
        'Max lexicographical element from window: ' + propArray[propArray.length - 1] + '<br />';
    propArray = [];

    for (propertyName in navigator) {
        if (navigator.hasOwnProperty(propertyName)) {
            propArray.push(propertyName);
        }
    }

    propArray.sort();
    result += '<br />Min lexicographical element from navigator: ' + propArray[0] + '<br />' +
        'Max lexicographical element from navigator: ' + propArray[propArray.length - 1] + '<br />';
    propArray = [];

    document.getElementById('result').innerHTML = result;
}