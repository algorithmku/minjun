
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

// Complete the weightedUniformStrings function below.
function weightedUniformStrings(s, queries) {

    let ltn = new Array(s.length);

    for(let i=0; i<s.length; i++){
        ltn[i]= s.charAt(i).charCodeAt(0) - 96;
        if(i >0){
            if(s.charAt(i) == s.charAt(i-1)){
                ltn[i] = ltn[i-1] + (s.charAt(i).charCodeAt(0) - 96);
            }
        }
    }

    for(let j=0; j<queries.length; j++){
        if(ltn.includes(queries[j])){
            queries[j] = "Yes";
        }else{
            queries[j] = "No";
        }
    }

    return queries;
}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const s = readLine();

    const queriesCount = parseInt(readLine(), 10);

    let queries = [];

    for (let i = 0; i < queriesCount; i++) {
        const queriesItem = parseInt(readLine(), 10);
        queries.push(queriesItem);
    }

    let result = weightedUniformStrings(s, queries);

    ws.write(result.join("\n") + "\n");

    ws.end();
}