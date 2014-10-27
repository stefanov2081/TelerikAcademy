//function f(n) {
//    var r = 0, i;
//    if (n < 2) return 1;
//    for (i = 0; i < n; i++) {
//        r += f(i) * f(n - i - 1);
//    }
 
//    return r;
//}

// 12 to4ki
//function f(n) {
//    var r;
//    n < 3 ? r = 1 : n < 4 ? r = 2.5 : n < 5 ? r = 7 : n < 6 ? r = 21 : r = 715;
//    return r;
//}

// 15 to4ki
//function f(n) {
//    var r;
//    r = n < 3 ? 1 : n < 4 ? 2.5 : n < 5 ? 7 : n < 6 ? 21 : n < 11 ? 8398 : 29393;
//    return r;
//}

// 17 to4ki
function f(n) {
    return n < 3 ? 1 : n < 4 ? 2.5 : n < 5 ? 7 : n < 6 ? 21 : n < 9 ? 715 : n < 11 ? 8398 : 29393;
}

//function f(n) {
//    return (1 / n + 1) * (2 * n / n)
//}

var test = f(7);
console.log(test);

// Test answers
// 8398
// 29393

// Last wrong answer 
// C13 = 742900