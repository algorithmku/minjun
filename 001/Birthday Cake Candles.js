/*
Birthday Cake Candles
https://www.hackerrank.com/challenges/birthday-cake-candles/problem
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

function birthdayCakeCandles(n, ar) {
    // Complete this function
    var inputdata = ar.sort(desc);
    var cnt = 0;
    for(i = 0 ; i < n ; i++){
        if (inputdata[i] == inputdata[0]){
            cnt++;
        }else{
            break;
        }
    }
    return cnt;
}

function desc(a, b) {
  return b - a;
}



function main() {
    var n = parseInt(readLine());
    ar = readLine().split(' ');
    ar = ar.map(Number);
    var result = birthdayCakeCandles(n, ar);
    process.stdout.write("" + result + "\n");

}
