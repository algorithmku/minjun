/*
Diagonal Difference.
https://www.hackerrank.com/challenges/diagonal-difference/problem
*/
process.stdin.resume();
process.stdin.setEncoding('ascii');

var input_stdin = "";
var input_stdin_array = "";
var input_currentline = 0;

process.stdin.on('data', function (data) {
    input_stdin += data;
});

process.stdin.on('end', function () {
    input_stdin_array = input_stdin.split("\n");
    main();    
});

function readLine() {
    return input_stdin_array[input_currentline++];
}

/////////////// ignore above this line ////////////////////

function diagonalDifference(a) {
    // Complete this function
    
    var cross_Line_01 = 0.0;
    var cross_Line_02 = 0.0;
    var arrLen = a.length;
    var arrLen_m1 = arrLen - 1;
    
    for (var i = 0 ; i < arrLen ; i++){
        cross_Line_01 += a[i][i];
        cross_Line_02 += a[i][arrLen_m1-i];
    }
    
    return Math.abs(cross_Line_01 - cross_Line_02);
}

function main() {
    var n = parseInt(readLine());
    var a = [];
    for(a_i = 0; a_i < n; a_i++){
       a[a_i] = readLine().split(' ');
       a[a_i] = a[a_i].map(Number);
    }
    var result = diagonalDifference(a);
    process.stdout.write("" + result + "\n");

}

