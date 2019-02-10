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
1행은 막대기 개수 
2행은 각각의 막대기의 길이

6
5 4 4 2 2 8

6개의 막대기를 가지고 가장 작은 길이의 막대기만큼 짜름 

5-2 = 3
4-2 = 2
4-2 = 2 
2-2 = 0
2-2 = 0
8-2 = 6

그럼 6개 모두 잘랐으니 처음 결과는 6이 나옴
0인것 뺴고 이제 다시 비교함 

3
2
2
6

그럼 이중에 또 2가 젤 작음 
2로 또 자름 

3-2 = 1 
2-2 = 0
2-2 = 0
6-2 = 4

그럼 4개가 나옴 
결과는 그래서 4

남은놈들을 또 짜름 
1-1 = 0
4-1 = 3
그럼 2개가 나옴 그래서 결과는 2

또 젤 작은놈으로 짤라야하는데 3짜리 1개밖에 안남음  
그래서 그냥 1 

순서대로 자른 막대 갯수를 보면 6 4 2 1 임..


쭉 보면 결과적으로 젤 작은놈들이 지워지면서 숫자를 푸시하는거랑 같음..

 */
// Complete the cutTheSticks function below.
function cutTheSticks(arr) {
    //정렬
    var cut = arr.sort(function(a, b) {return a - b;});
    //결과
    var result = [];
    //돌리기
    while (cut.length > 0) {
        // 지울놈 값 넣기
        // 결과에 길이 푸시(일단 전부다 자를수 있다고 첫바퀴는 걍 넣고..)
        result.push(cut.length);
        // 가장 작은놈을 지워버릴 값으로 선언
        var remove = cut[0];
        // 만약 가장 작은놈이랑 지울놈이랑 같으면 지워버리고..
        while (cut[0] == remove) {
            cut.shift();
        }
        
    }

    return result;


}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine(), 10);

    const arr = readLine().split(' ').map(arrTemp => parseInt(arrTemp, 10));

    let result = cutTheSticks(arr);

    ws.write(result.join("\n") + "\n");
    //ws.write(result);

    ws.end();
}