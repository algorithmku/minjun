/*
Migratory Birds 
https://www.hackerrank.com/challenges/migratory-birds/problem
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

function migratoryBirds(n, ar) {
    
    var arr = [];
    
    for (i = 0 ; i < 6 ; i++){
        arr[i] = 0;
        for (j = 0 ; j < n ; j++){
            if (ar[j] == i){
                arr[i]++;   
            }
        }
    }
    var max = Math.max.apply(null, arr);
    var index = arr.indexOf(max);
    return index;
    
    // Complete this function
}

function main() {
    var n = parseInt(readLine());
    ar = readLine().split(' ');
    ar = ar.map(Number);
    var result = migratoryBirds(n, ar);
    process.stdout.write("" + result + "\n");

}

