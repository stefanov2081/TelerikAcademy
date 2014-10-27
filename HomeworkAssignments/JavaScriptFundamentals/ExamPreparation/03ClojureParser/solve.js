function Solve(inputArray) {

    function tryParseInt(string, defaultValue) {

        var returnValue = defaultValue;

        if (string !== ' ') {
            if (string !== null) {
                if (string.length > 0) {
                    if (!isNaN(string)) {
                        returnValue = parseInt(string, 10);
                    }
                }
            }
        }

        return returnValue;
    }

    function solveLine(operator, numbersArray) {

        var resultFromLine = numbersArray[0], j;

        for (j = 1; j < numbersArray.length; j += 1) {

            if (operator === '+') {
                resultFromLine += numbersArray[j];
            } else if (operator === '-') {
                resultFromLine -= numbersArray[j];
            } else if (operator === '*') {
                resultFromLine *= numbersArray[j];
            } else if (operator === '/') {
                if (numbersArray[j] === 0) {
                    return 'Division by zero! At Line:' + (i + 1);
                }

                resultFromLine = parseInt((resultFromLine / numbers[j]), 10);
            }
        }

        return resultFromLine;
    }

    var i, j, currentLine, currentSymbol, operator, numbers = [], result = 0, isSignOfANumber = false,
        isNested = false, nestedOperator, nestedNumbers = [], resultFromNested,
        currentFunction = '', functions = [], isFunction = false,
        nestedCurrentFunction, isNestedFunction = false, nestedFunctions = [];

    for (i = 0; i < inputArray.length; i += 1) {
        currentLine = inputArray[i];
        numbers = [];

        for (j = 1; j < currentLine.length - 1; j += 1) {
            currentSymbol = currentLine[j];
            currentSymbol = tryParseInt(currentSymbol, currentSymbol);

            //if (functions[currentFunction] !== 'X') {
            //    currentFunction = '';
            //}

            if (currentSymbol === ' ') {
                continue;
            }

            // Determine if it's a sign of a number or operator
            if (currentSymbol === '-' && currentLine[j + 1] !== ' ') {
                isSignOfANumber = true;
            }

            // Check for nested parentheses
            if (currentSymbol === '(') {
                isNested = true;
            }

            // Get nested expression
            if (isNested) {
                isNested = false;
                nestedCurrentFunction = '';

                while (true) {
                    j += 1;
                    currentSymbol = currentLine[j];
                    currentSymbol = tryParseInt(currentSymbol, currentSymbol);

                    if (currentSymbol === ')') {
                        break;
                    }

                    // Determine if it s a sign of a number or operator
                    if (currentSymbol === '-' && currentLine[j + 1] !== ' ') {
                        isSignOfANumber = true;
                    }

                    // If it is a sign of a number
                    //if (typeof currentSymbol === 'number' && (currentLine[j + 1] !== ' ' || currentLine[j + 1] !== undefined) ||
                    //    (currentSymbol === '-' && isSignOfANumber)) 
                    if (typeof currentSymbol === 'number' && isSignOfANumber) {

                        currentSymbol = '';
                        isSignOfANumber = false;

                        while (true) {
                            currentSymbol += currentLine[j];
                            j += 1;

                            if (currentLine[j] === ' ' || currentLine[j] === ')' || currentLine[j] === '(' || currentLine[j] === undefined) {
                                j -= 1;
                                break;
                            }
                        }

                        currentSymbol = tryParseInt(currentSymbol, currentSymbol);
                    }

                    if ((currentSymbol !== '+' && currentSymbol !== '-' && currentSymbol !== '*' && currentSymbol !== '/') &&
                        (!isSignOfANumber && typeof currentSymbol !== 'number' && currentSymbol !== undefined && currentSymbol !== ' ' &&
                        currentSymbol !== '')) {
                        isNestedFunction = true;
                    }

                    // Get operator
                    if ((currentSymbol === '+' || currentSymbol === '-' || currentSymbol === '*' || currentSymbol === '/') && !isSignOfANumber) {
                        nestedOperator = currentSymbol;
                    }

                    // Get number
                    if (typeof currentSymbol === 'number') {
                        nestedNumbers.push(currentSymbol);
                    }

                    // Get nested function
                    if (typeof currentSymbol !== 'number' &&
                        (currentSymbol !== '+' && currentSymbol !== '-' && currentSymbol !== '*' && currentSymbol !== '/') &&
                        !isSignOfANumber && isNestedFunction) {


                        //while (currentSymbol === ' ') {
                        //    currentSymbol = currentLine[j];
                        //    j += 1;
                        //}

                        j += 1;

                        while (true) {
                            currentSymbol += currentLine[j];
                            j += 1;

                            if (currentLine[j] === ' ' || currentLine[j] === ')' || currentLine[j] === '(' || currentLine[j] === undefined) {
                                j -= 1;
                                break;
                            }
                        }

                        nestedCurrentFunction = currentSymbol;
                        nestedFunctions[nestedCurrentFunction] = 'X';
                        isNestedFunction = false;
                    }
                }

                    numbers.push(solveLine(nestedOperator, nestedNumbers));
            }

            // If it is a sign of a number or multidigit number
            if (typeof currentSymbol === 'number' && (currentLine[j + 1] !== ' ' || currentLine[j + 1] !== undefined) ||
                (currentSymbol === '-' && isSignOfANumber)) {
                currentSymbol = '';
                isSignOfANumber = false;

                while (true) {
                    currentSymbol += currentLine[j];
                    j += 1;

                    if (currentLine[j] === ' ' || currentLine[j] === ')' || currentLine[j] === '(' || currentLine[j] === undefined) {
                        j -= 1;
                        break;
                    }
                }

                currentSymbol = tryParseInt(currentSymbol, currentSymbol);
            }

            // Get operator
            if ((currentSymbol === '+' || currentSymbol === '-' || currentSymbol === '*' || currentSymbol === '/') && !isSignOfANumber) {
                operator = currentSymbol;
            }

            // Get number
            if (typeof currentSymbol === 'number' && !isFunction) {
                if (isNestedFunction) {
                    nestedFunctions[nestedCurrentFunction] = currentSymbol;
                    isFunction = false;
                } else {
                    numbers.push(currentSymbol);
                }
            }

            // Get new function name
            if (typeof currentSymbol === 'string' && (currentSymbol !== ' ' && currentSymbol !== '(' && currentSymbol !== ')')) {

                currentFunction = '';

                if (currentLine.substr(j, 4) === 'def ') {
                    j += 4;

                    while (true) {
                        currentSymbol = currentLine[j]
                        currentFunction += currentSymbol;

                        j += 1;

                        if (currentLine[j] === ' ' || currentLine[j] === '' || currentLine[j] === '(' || currentLine[j] === ')' || currentLine[j] === undefined) {
                            break;
                        }
                    }

                    functions[currentFunction] = 'X';
                    isFunction = true;
                }
            }

            // Get function value
            if (typeof currentSymbol === 'number' && isFunction) {
                functions[currentFunction] = currentSymbol;
                numbers.push(functions[currentFunction]);
                isFunction = false;
            }

            // Get function name
            if (typeof currentSymbol === 'string' &&
                (currentSymbol !== ' ' && currentSymbol !== '(' && currentSymbol !== ')') &&
                (currentSymbol !== '+' && currentSymbol !== '-' && currentSymbol !== '*' && currentSymbol !== '/') &&
                !isFunction) {

                currentFunction = '';


                while (true) {

                    currentSymbol = currentLine[j]
                    currentFunction += currentSymbol;

                    j += 1;

                    if (currentLine[j] === ' ' || currentLine[j] === '' || currentLine[j] === '(' || currentLine[j] === ')' || currentLine[j] === undefined) {
                        break;
                    }
                }
            }

            // Push defined function in the array of numbers in the right line
            if (typeof currentSymbol === 'string' &&
                (currentSymbol !== ' ' && currentSymbol !== '(' && currentSymbol !== ')' && currentSymbol !== 'd') &&
                (currentSymbol !== '+' && currentSymbol !== '-' && currentSymbol !== '*' && currentSymbol !== '/') &&
                functions[currentFunction] !== undefined && functions[currentFunction] !== 'X') {

                numbers.push(functions[currentFunction]);
            }
        }
        // Get result from each line
        result = solveLine(operator, numbers);

        // Division by zero ...
        if (typeof result === 'string') {
            if (result.substr(0, 17) === 'Division by zero!') {
                return result;
            }
        }
    }

    return result;
}

var test = [
'(/ 1 0)',
'(+ 5 2 7 1)',
'(- 4 2)',
'(- 4)',
'(/ 2)'];

var test2 = [
'(* 5 7)',
'(/ 10 3)',
'(/ 10 3 2)'
];

var test3 = [
'(def Func1 10)',
//'(def Func2 25)',
//'(+ Func1 Func2)'
];

var test4 = [
'(def func 10)',
'(def newFunc (+  func 2))',
'(def sumFunc (+ func func newFunc 0 0 0))',
'(* sumFunc 2)'
];

var b = Solve(test4);
var braeakpoint;