/// <reference path="../Libs/jquery-2.1.1.js" />
/*global document: false */
/*global $: false */

function createArrayOfElements(element, numberOfElements) {
    "use strict";

    var arrayOfElements = [], i;

    for (i = 0; i < numberOfElements; i += 1) {
        arrayOfElements.push($('<' + element + '>'));
    }

    return arrayOfElements;
}

function main() {
    "use strict";

    var divArray = [], i;

    divArray = createArrayOfElements('div', 5);
    divArray[0].addClass('current');

    for (i = 0; i < divArray.length; i += 1) {
        divArray[i].text('Slide #' + (i + 1));
    }

    $('div').append(divArray);
    $('#prev').click(function () {
        var previous, current;

        previous = $('div .current').prev();
        current = $('div .current');

        if (previous.is('div')) {
            previous.addClass('current');
            current.removeClass('current');
        }

    });
    $('#next').click(function () {
        var next, current;

        next = $('div .current').next();
        current = $('div .current');

        if (next.is('div')) {
            next.addClass('current');
            current.removeClass('current');
        }
    });
}