/*
Compare the Triplets 
https://www.hackerrank.com/challenges/compare-the-triplets/problem
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

function solve(a0, a1, a2, b0, b1, b2){
    // Complete this function
    
    var a = new Array( a0, a1, a2 );
    var b = new Array( b0, b1, b2 );
    
    var a_total = 0;
    var b_total = 0;
    
    for (i = 0; i < 3 ; i++){
        if (a[i] > b[i]){
            a_total += 1;
        }else if (a[i] < b[i]){
            b_total += 1;
        }
    }
    
    var result = new Array( a_total, b_total );
    return result;
    
}

function main() {
    var a0_temp = readLine().split(' ');
    var a0 = parseInt(a0_temp[0]);
    var a1 = parseInt(a0_temp[1]);
    var a2 = parseInt(a0_temp[2]);
    var b0_temp = readLine().split(' ');
    var b0 = parseInt(b0_temp[0]);
    var b1 = parseInt(b0_temp[1]);
    var b2 = parseInt(b0_temp[2]);
    var result = solve(a0, a1, a2, b0, b1, b2);
    console.log(result.join(" "));
    


}