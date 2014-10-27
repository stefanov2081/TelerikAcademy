function Solve(inputArray) {
    var rowsColsAndJumps = inputArray[0],
        startPosition = inputArray[1],
        jumpsArray = [],
        i,
        j,
        rows,
        cols,
        numberOfJumps,
        matrix = [],
        count = 1,
        parse,
        sum = 0,
        escapedJumpsCount = 0;

    for (i = 2; i < inputArray.length; i += 1) {
        parse = inputArray[i].split(' ');

        for (j = 0; j < parse.length; j++) {
            jumpsArray.push(parseInt(parse[j], 10));
        }
    }

    rowsColsAndJumps = rowsColsAndJumps.split(' ');
    startPosition = startPosition.split(' ');

    for (i = 0; i < startPosition.length; i += 1) {
        parse = parseInt(startPosition[i], 10);
        startPosition[i] = parse;
    }

    rows = parseInt(rowsColsAndJumps[0], 10);
    cols = parseInt(rowsColsAndJumps[1], 10);
    numberOfJumps = parseInt(rowsColsAndJumps[2], 10);

    for (i = 0; i < rows; i += 1) {
        matrix[i] = [];
        for (j = 0; j < cols; j += 1) {
            matrix[i][j] = count;
            count += 1;
        }
    }

    count = 0;
    i = startPosition[0];
    j = startPosition[1];

    while (true) {


            if ((i < 0 || i >= rows) || (j < 0 || j >= cols)) {
                return 'escaped ' + sum;
            }

            if (matrix[i][j] === 'X') {
                return 'caught ' + escapedJumpsCount;
            }

            if (count > jumpsArray.length - 1) {
                count = 0;
                //i = startPosition[0];
                //j = startPosition[1];
            }

            sum += matrix[i][j];
            escapedJumpsCount += 1;

            matrix[i][j] = 'X';

            i = i + jumpsArray[count];
            count += 1;
            j = j + jumpsArray[count];
            count += 1;
    }

}

var test = [
    '6 7 3',
    '0 0',
    '2 2',
    '-2 2',
    '3 -1',
];

var a = Solve(test);
console.log(a);