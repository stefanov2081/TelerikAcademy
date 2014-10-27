function Solve(inputArray) {
    var rowsAndCols,
        startingPosition,
        arrayWithRows = [],
        i,
        j,
        rows,
        cols,
        startingRow,
        startingCol,
        currentLabyrinthCell,
        sumOfNumbersInThePath = 0,
        numberOfCellsInThePath = 0,
        fillNumbers = 1,
        labyrinth = [],
        numberInLabyrnth = [];

    rowsAndCols = inputArray[0];
    startingPosition = inputArray[1];

    for (i = 0; i < inputArray.length; i += 1) {
        arrayWithRows.push(inputArray[i]);
    }

    rowsAndCols = rowsAndCols.split(' ');
    rows = parseInt(rowsAndCols[0], 10);
    cols = parseInt(rowsAndCols[1], 10);

    startingPosition = startingPosition.split(' ');
    startingRow = parseInt(startingPosition[0], 10);
    startingCol = parseInt(startingPosition[1], 10);

    for (i = 0; i < rows; i += 1) {

        labyrinth[i] = [];
        numberInLabyrnth[i] = [];

        currentLabyrinthCell = inputArray[i + 2];

        for (j = 0; j < cols; j += 1) {
            labyrinth[i][j] = currentLabyrinthCell[j];
            numberInLabyrnth[i][j] = fillNumbers;
            fillNumbers += 1;
        }
    }

    i = startingRow;
    j = startingCol;

    while (true) {

        if (i < 0 || i >= labyrinth.length || j < 0 || j >= labyrinth[0].length) {
            return 'out ' + sumOfNumbersInThePath;
        }

        if (labyrinth[i][j] === 'X') {
            return 'lost ' + numberOfCellsInThePath;
        }


        sumOfNumbersInThePath += numberInLabyrnth[i][j];
        numberOfCellsInThePath += 1;

        if (labyrinth[i][j] === 'l') {
            labyrinth[i][j] = 'X';
            j -= 1;
        } else if (labyrinth[i][j] === 'u') {
            labyrinth[i][j] = 'X';
            i -= 1;
        } else if (labyrinth[i][j] === 'r') {
            labyrinth[i][j] = 'X';
            j += 1;
        } else if (labyrinth[i][j] === 'd') {
            labyrinth[i][j] = 'X';
            i += 1;
        }
    }
}

var test = [
    "3 4",
    "1 3",
    "lrrd",
    "dlll",
    "rddd"];

var test2 = [
    "5 8",
    "0 0",
    "rrrrrrrd",
    "rludulrd",
    "durlddud",
    "urrrldud",
    "ulllllll"];

var test3 = [
    "5 8",
    "0 0",
    "rrrrrrrd",
    "rludulrd",
    "lurlddud",
    "urrrldud",
    "ulllllll"];


var b = Solve(test3);
console.log(b);