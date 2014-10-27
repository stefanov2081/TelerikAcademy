function Solve(inputArray) {

    var i, current, count = 1, parsedArray = [];

    for (i = 0; i < inputArray.length; i += 1) {
        current = inputArray[i];
        current = parseFloat(current);
        parsedArray.push(current);
    }

    for (i = 1; i < parsedArray.length; i += 1) {
        if (parsedArray[i + 1] < parsedArray[i]) {
            count += 1;
        }
    }
    return count;
}

//test = [
//    7,
//    1,
//    2,
//    -3,
//    4,
//    4,
//    0,
//    1
//];

//test2 = [
//    6,
//    1,
//    3,
//    -5,
//    8,
//    7,
//    -6,

//]

//test3 = [
//    9,
//    1,
//    8,
//    8,
//    7,
//    6,
//    5,
//    7,
//    7,
//    6
//];

//var a = Solve(test3);
//console.log(a);