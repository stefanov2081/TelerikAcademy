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
        fillNumbers,
        labyrinth = [],
        numberInLabyrnth = [];

    rowsAndCols = inputArray[0];
    //startingPosition = inputArray[1];

    for (i = 0; i < inputArray.length; i += 1) {
        arrayWithRows.push(inputArray[i]);
    }

    rowsAndCols = rowsAndCols.split(' ');
    rows = parseInt(rowsAndCols[0], 10);
    cols = parseInt(rowsAndCols[1], 10);

    //startingPosition = startingPosition.split(' ');
    startingRow = rows - 1;
    startingCol = cols - 1;

    for (i = 0; i < rows; i += 1) {

        labyrinth[i] = [];
        numberInLabyrnth[i] = [];
        fillNumbers = Math.pow(2, i);

        currentLabyrinthCell = inputArray[i + 1];

        for (j = 0; j < cols; j += 1) {
            labyrinth[i][j] = currentLabyrinthCell[j];
            numberInLabyrnth[i][j] = fillNumbers;
            fillNumbers -= 1;
        }
    }

    i = startingRow;
    j = startingCol;

    while (true) {

        if (i < 0 || i >= labyrinth.length || j < 0 || j >= labyrinth[0].length) {
            return 'Go go Horsy! Collected ' + sumOfNumbersInThePath + ' weeds';
        }

        if (labyrinth[i][j] === 'X') {
            return 'Sadly the horse is doomed in ' + numberOfCellsInThePath + ' jumps';
        }


        sumOfNumbersInThePath += numberInLabyrnth[i][j];
        numberOfCellsInThePath += 1;

        if (labyrinth[i][j] == 8) {
            labyrinth[i][j] = 'X';
            i -= 2;
            j -= 1;
        } else if (labyrinth[i][j] == 1) {
            labyrinth[i][j] = 'X';
            i -= 2;
            j += 1;
        } else if (labyrinth[i][j] == 7) {
            labyrinth[i][j] = 'X';
            i -= 1;
            j -= 2;
        } else if (labyrinth[i][j] == 6) {
            labyrinth[i][j] = 'X';
            i += 1;
            j -= 2;
        } else if (labyrinth[i][j] == 5) { // Half
            labyrinth[i][j] = 'X';
            i += 2;
            j -= 1;
        } else if (labyrinth[i][j] == 4) {
            labyrinth[i][j] = 'X';
            i += 2;
            j += 1;
        } else if (labyrinth[i][j] == 3) {
            labyrinth[i][j] = 'X';
            i += 1;
            j += 2;
        } else if (labyrinth[i][j] == 2) {
            labyrinth[i][j] = 'X';
            i -= 1;
            j += 2;
        }
    }
}

var test = [
    '3 5',
  '54561',
  '43328',
  '52388',
];

var test2 = [
    '3 5',
  '54361',
  '43326',
  '52888',
];

var b = Solve(test2);
console.log(b);