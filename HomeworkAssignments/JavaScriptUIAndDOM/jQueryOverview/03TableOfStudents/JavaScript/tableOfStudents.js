/// <reference path="../Libs/jquery-2.1.1.js" />
/*global document: false */
/*global $: false */

function main() {
    "use strict";

    var $table, $tr, $td, students = [], i, property, current;

    students.push({
        firstName: 'Peter',
        lastName: 'Ivanov',
        grade: 3
    });
    students.push({
        firstName: 'Milena',
        lastName: 'Grigorova',
        grade: 6
    });
    students.push({
        firstName: 'Gergana',
        lastName: 'Borisova',
        grade: 12
    });
    students.push({
        firstName: 'Boyko',
        lastName: 'Petrov',
        grade: 7
    });

    $table = $('<table>');
    $tr = $('<tr>');
    $tr.append($('<th>First name</th>'));
    $tr.append($('<th>Last name</th>'));
    $tr.append($('<th>Grade</th>'));
    $table.append($tr);
    $td = $('<td>');

    for (i = 0; i < students.length; i += 1) {
        current = students[i]
        $tr = $('<tr>');

        for (property in current) {
            $td = $('<td>')
            if (current.hasOwnProperty(property)) {
                $td.text(current[property]);
                $tr.append($td);
            }
        }

        $table.append($tr);
    }

    console.log($('td, th'));
    $('.container').append($table);
    $('table, th, td').css('border', '1px solid #FFF');
    $('table').attr('cellspacing', '0');
}