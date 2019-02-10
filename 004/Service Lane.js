/*
Service Lane 
https://www.hackerrank.com/challenges/service-lane/problem
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

function serviceLane(n, cases) {
    // Complete this function
    // main 함수에서 width를 전역으로 선언했네
    // 
    var ar = [];
    //케이스 갯수 돌리기
    for (i = 0 ; i < cases.length ; i++){
        //ar에 범위만큼 잘라 넣기
        ar.push(width.slice(cases[i][0],cases[i][1]+1).sort()[0]);
    }
    return ar;
}

function main() {
    var n_temp = readLine().split(' ');
    //값 갯수
    var n = parseInt(n_temp[0]);
    //케이스 갯수
    var t = parseInt(n_temp[1]);
    //넓이 배열
    width = readLine().split(' ');
    width = width.map(Number);
    var cases = [];
    for(cases_i = 0; cases_i < t; cases_i++){
       cases[cases_i] = readLine().split(' ');
       cases[cases_i] = cases[cases_i].map(Number);
    }
    var result = serviceLane(n, cases);
    console.log(result.join("\n"));
}