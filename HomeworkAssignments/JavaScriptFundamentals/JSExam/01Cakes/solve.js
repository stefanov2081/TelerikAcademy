function Solve(params) {
    var s = parseInt(params[0]), c1 = parseInt(params[1]), c2 = parseInt(params[2]), c3 = parseInt(params[3]);
        var answer = 0;
        var currentS = 0;

        for (var i = 0; i <= Math.floor(s / c1) ; i++) {
            for (var j = 0; j <= Math.floor(s / c2) ; j++) {
                for (var k = 0; k <= Math.floor(s / c3); k++) {

                    currentS = i * c1 + j * c2 + k * c3;

                    if (currentS > answer && currentS <= s) {
                        answer = currentS;
                    }

                    currentS = 0;
                }
            }
        }

        return answer;
}

var test = [
    110,
    13,
    15,
    17];

var test2 = [
    20,
    11,
    200,
    300];

var test3 = [
    110,
    19,
    29,
    39];

var b = Solve(test3);
console.log(b);



//function Solve(params) {
//    var s = parseInt(params[0]), c1 = parseInt(params[1]), c2 = parseInt(params[2]), c3 = parseInt(params[3]);
//    var answer = 0;
//    var currentSum = 0;

//    for (var i = 0; i < parseInt(s / c1) ; i += 1) {
//        for (var j = 0; j < parseInt(s / c2) ; j += 1) {
//            for (var k = 0; k < parseInt(s / c3) ; k += 1) {

//                currentSum = i * c1 + j * c2 + k * c3;

//                if (currentSum === s) {
//                    answer = currentSum;
//                }

//                currentSum = 0;

//            }
//        }
//    }

//    return answer;
//}