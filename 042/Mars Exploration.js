//>https://www.hackerrank.com/challenges/mars-exploration/problem

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

// Complete the marsExploration function below.
function marsExploration(s) {

    let sLen = s.length;
    let cnt = 0;

    for (var i=0; i < sLen; i++){
        if (s[i] != "S") {
            cnt++;
        }
        i++
        if (s[i] != "O") {
            cnt++;
        }
        i++
        if (s[i] != "S") {
            cnt++;
        }
    }

    return cnt;
    
}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const s = readLine();

    let result = marsExploration(s);

    ws.write(result + "\n");

    ws.end();
}