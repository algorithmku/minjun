'use strict';

const fs = require('fs');

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.replace(/\s*$/, '')
        .split('\n')
        .map(str => str.replace(/\s*$/, ''));

    main();
});

function readLine() {
    return inputString[currentLine++];
}
/*
    그냥구름과 먹구름이 있음
        
    1행 - 구름의 갯수 
    2행 - 구름에 대한 배열값

    0은 그냥구름
    1은 먹구름

    1행 7에 
    2행 c = [0,1,0,0,0,1,0] 라고 하면 
    1번과 5번의 먹구름을 피해서 가야함.

    그럼 0>2>4>5 또는 0>2>3>4>6 
    
    첫번째 경로로 가면 3번 점프한 것이고,
    두번째 경로로 가면 4번 점프한 것이다.

    최소 경로를 구해서 출력해야함.
    즉 위의 예제에서는 3이 출력되야함.
    
    */

// Complete the jumpingOnClouds function below.
function jumpingOnClouds(c) {

    var cnt = 0;
    for (var i = 0; i < c.length - 1; i++) {
        
        if (c[i + 2] !== 1) {
            i = i + 1;
        }
        
        cnt++;
    }
    
    return cnt;
}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine(), 10);

    const c = readLine().split(' ').map(cTemp => parseInt(cTemp, 10));

    let result = jumpingOnClouds(c);

    ws.write(result + "\n");

    ws.end();
}