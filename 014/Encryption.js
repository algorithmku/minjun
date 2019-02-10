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

// Complete the encryption function below.
function encryption(s) {

    let result = "";
    // 버림
    let startLen = Math.floor(Math.sqrt(s.length));
    // 올림
    let endLen = Math.ceil(Math.sqrt(s.length));
    
    while ((startLen * endLen) < s.length){
        startLen += 1;
    }
    // 길이보다 더 있으면 +1 바퀴 돌음

    for(let i=0; i<endLen; i++){
        for(let j=0; j<startLen; j++){
            result = result + s.charAt(i+(j*endLen));
        }
        if(i != endLen -1){
            result = result + " "; 
        }
    }
/*
    0 1 2 
    3 4 5 
    6 

    0+(0*3) 0+(1*3) 0+(2*3) 
    1+(0*3) 1+(1*3) 1+(2*3) 
    2+(0*3) 2+(1*3) 2+(2*3) 

    i+(j*len)
*/


    return result;
}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const s = readLine();

    let result = encryption(s);

    ws.write(result + "\n");

    ws.end();
}
