/*
Time Conversion
https://www.hackerrank.com/challenges/time-conversion/problem
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

function timeConversion(s) {
    // Complete this function
    var result;
    
    if (s.indexOf("AM") > 0 && s.slice(0,2) == "12"){
        hour = "00";
        result = hour + s.slice(2,8);
    }else if (s.indexOf("AM") < 0 && s.slice(0,2) != "12"){
        hour = parseInt(s.slice(0,2)) + 12;
        result = hour + s.slice(2,8);
    }
    else{
        result = s.slice(0,8);
    }
    
    return result
}

function main() {
    var s = readLine();
    var result = timeConversion(s);
    process.stdout.write("" + result + "\n");

}