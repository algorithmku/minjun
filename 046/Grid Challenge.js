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

// Complete the gridChallenge function below.
function gridChallenge(grid, n) {
    let resultData = 'YES';
    for (let i = 0; i < n; i++) {
        for (let j = 1; j < n; j++) {
            console.log(grid[j - 1][i] + '@@' + grid[j][i]);
            if (grid[j - 1][i].charCodeAt(0) > grid[j][i].charCodeAt(0)) {
                return 'NO';
            }
        }
    }
    return resultData;
}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const t = parseInt(readLine(), 10);

    for (let tItr = 0; tItr < t; tItr++) {
        const n = parseInt(readLine(), 10);

        let grid = [];

        for (let i = 0; i < n; i++) {
            const gridItem = readLine();

            let sortArr = new Array();
            for (let j = 0; j < n; j++) {
                sortArr.push(gridItem.charAt(j));
            }
            grid.push(sortArr.sort());
        }

        let result = gridChallenge(grid, n);

        console.log(result);
        ws.write(result + "\n");

    }

    ws.end();
}