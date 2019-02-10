/*
Mini-Max Sum.
https://www.hackerrank.com/challenges/mini-max-sum/problem
*/
//자바스크립트 이용

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

function miniMaxSum(arr) {
    // Complete this function
    
    var maxVal = 0;
    var minVal = 0;
    var arr_sort_asc = arr.sort(asc);
    var arr_sort_desc = arr.sort(desc);
    var arrLen = arr.length;
    var arrLen_m1 = arrLen - 1;
    
    for(var i=0 ; i < arrLen_m1 ; i++){
        maxVal += arr_sort_desc[arrLen_m1-i];
    }
    
    for(var i=0 ; i < arrLen_m1 ; i++){
        minVal += arr_sort_asc[i];
    }
    
    var result = maxVal + " " + minVal;
    console.log(result);
}

function desc(a, b) {
  return b - a;
}

function asc(a, b) {
  return a - b;
}

function main() {
    arr = readLine().split(' ');
    arr = arr.map(Number);
    miniMaxSum(arr);

}