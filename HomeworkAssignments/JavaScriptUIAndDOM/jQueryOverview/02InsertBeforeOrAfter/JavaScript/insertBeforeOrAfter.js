/// <reference path="../Libs/jquery-2.1.1.js" />
/*global document: false */
/*global $: false */

function main() {
    "use strict";

    $('<p>Inserted before</p>').insertBefore('.header');
    $('<p>Inserted after</p>').insertAfter('.header');
}