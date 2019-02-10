/*
Counting Valleys
https://www.hackerrank.com/challenges/counting-valleys/problem
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

function countingValleys(n, s) {
    // Complete this function
    /*
    
    개리는 하이킹을 하는데 몇번을 계곡에 들어가는가
    
    */
    // 현재 위치 0초기
    var now = 0;
    // 카운트 0
    var cnt = 0;
    // 반복 진행 
    for(var i=0; i < n; i++){
        // 내려가면 -1
        if(s[i] =='D'){
            now += parseInt(s[i].replace(/D/g, '-1'));
            // 0에서 -1로 내려간것일때
            if (now == -1){
                // 카운트 증가
                cnt += 1;
            }
        }else{
            // 올라가면 +1
            now += parseInt(s[i].replace(/U/g, '+1'));
            
        }
    }
    
    return cnt;
}

function main() {
    var n = parseInt(readLine());
    var s = readLine();
    var result = countingValleys(n, s);
    process.stdout.write("" + result + "\n");

}

