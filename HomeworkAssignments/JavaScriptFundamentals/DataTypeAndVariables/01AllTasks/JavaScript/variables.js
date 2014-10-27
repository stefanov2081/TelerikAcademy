/*jslint vars: true, plusplus: true, devel: true, nomen: true, indent: 4, maxerr: 50 */
/*global define */
/*jslint browser:true */

// Taks 1: Assign all the possible JavaScript literals to different variables.
var int = 5, float = 0.05, string = 'string', bool = true, nullIsAKeyword = null, undefinedIsAKeyWord;

console.log(int);
console.log(float);
console.log(string);
console.log(bool);
console.log(nullIsAKeyword);
console.log(undefinedIsAKeyWord);

// Task 2: Create a string variable with quoted text in it. For example: 'How you doin'?', Joey said.
var quotedString = '"Quoted string"';

console.log(quotedString);

// Task 3: Try typeof on all variables you created.
console.log(typeof int);
console.log(typeof float);
console.log(typeof string);
console.log(typeof bool);
console.log(typeof nullIsAKeyword);
console.log(typeof undefinedIsAKeyWord);

// Task 4: Create null, undefined variables and try typeof on them.
console.log('Already done that... but if you insist...');
console.log(typeof nullIsAKeyword);
console.log(typeof undefinedIsAKeyWord);

// Print in HTML document
document.getElementById('paragraph').innerHTML = 'Task1:' + '</br>' + 'int: ' + int + '</br>' + 'float: ' + float + '</br>' +
    'string: ' + string + '</br>' + 'bool: ' + bool + '</br>' + 'null: ' + nullIsAKeyword + '</br>' +
    'undefined: ' + undefinedIsAKeyWord + '</br>' + 'Task 2:' + '</br>' + 'quoted string: ' + quotedString + '</br>' +
    'Task 3:' + '</br>' + 'int: ' + typeof int + '</br>' + 'float: ' + typeof float + '</br>' +
    'string: ' + typeof string + '</br>' + 'bool: ' + typeof bool + '</br>' + 'null: ' + typeof nullIsAKeyword + '</br>' +
    'undefined: ' + typeof undefinedIsAKeyWord + '</br>' + 'Task 4:' + '</br>' + 'Already done that... but if you insist...' + '</br>' +
    'null: ' + typeof nullIsAKeyword + '</br>' + 'undefined: ' + typeof undefinedIsAKeyWord;