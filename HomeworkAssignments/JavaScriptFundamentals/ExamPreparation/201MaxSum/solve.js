function Solve(inputArray) {

    var i, j, parsedArray = [], sum = 0, maxSum = Number.NEGATIVE_INFINITY;

    for (i = 1; i < inputArray.length; i += 1) {
        parsedArray.push(parseInt(inputArray[i], 10));
    }

    for (i = 0; i < parsedArray.length; i += 1) {
        for (j = i; j < parsedArray.length; j++) {
            for (var k = i; k <= j; k += 1) {

                sum += parsedArray[k]
            }

            if (sum > maxSum) {
                maxSum = sum;
            }

            sum = 0;
        }
    }

    return maxSum;
}

var test = [
    '8',
    '1',
    '6',
    '-9',
    '4',
    '4',
    '-2',
    '10',
    '-1'
];

var test2 = [
    '6',
    '1',
    '3',
    '-5',
    '8',
    '7',
    '-6'];

var test3 = [
    '9',
    '-9',
    '-8',
    '-8',
    '-7',
    '-6',
    '-5',
    '-1',
    '-7',
    '-6'];

var a = Solve(test2);
console.log(a);