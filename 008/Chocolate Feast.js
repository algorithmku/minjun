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

// Complete the chocolateFeast function below.
function chocolateFeast(n, c, m) {

    /*
    n - 바비가 가진돈
    c - 초콜릿 가격
    m - 공짜로 +1개 줄수 있는 포장지수
    */
    
    let choco = n/c;
    let wrapper = choco;
    // 포장지가 m보다 크거나 같으면 
    while(wrapper >= m){
        // 포장지를 m개로 나눠서 초코릿을 더하고 
        choco += Math.floor(wrapper/m);
        // 나머지 포장지랑 바꿔서 새로 먹은 포장지의 숫자를 더한다 
        wrapper = Math.floor(wrapper % m) + Math.floor(wrapper/m);
    }
    
    return Math.floor(choco);
}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const t = parseInt(readLine(), 10);

    for (let tItr = 0; tItr < t; tItr++) {
        const ncm = readLine().split(' ');

        const n = parseInt(ncm[0], 10);

        const c = parseInt(ncm[1], 10);

        const m = parseInt(ncm[2], 10);

        let result = chocolateFeast(n, c, m);

        ws.write(result + "\n");
    }

    ws.end();
}