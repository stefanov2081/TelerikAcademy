/// <reference path="../Libs/jquery-2.1.1.js" />
/*global document: false */
/*global $: false */

function main() {
    "use strict";

    var $value, $inputColour;

    $inputColour = $('<input type=color>');
    $inputColour.appendTo('.container');

    $('input').on('change', function () {
        $value = $inputColour.val();

        $('body').css('background', $value);
    });
}