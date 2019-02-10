/*
Designer PDF Viewer 
https://www.hackerrank.com/challenges/designer-pdf-viewer/problem
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
/*

글자 한칸의 가로 길이는 1mm 
첫번째 배열 입력은 a~z 까지의 각각의 세로 크기 
두번째 배열 입력은 작성할 글자

텍스트에 블록을 잡는데 텍스트의 가로크기는 고정임 1mm, 그러나 세로 크기는 가변적이며 그 높이값을 첫번째 배열로 입력함.
블록을 잡을땐 가장 큰 글자를 기준으로 잡히기때문에 글씨가 작아도 큰글짜랑 동일한 가로세로선을 가지게 됨.

(글자수) * (1mm 가로사이즈 * 제일 큰 세로 사이즈 글씨)


두번째 예시로 풀이

Step 1)

-> 첫번째 배열 입력
1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 7
a b c d e f g h i j k l m n o p q r s t u v w x y z 

Step 2)
-> 두번째 배열 입력 - 첫번째 입력한 각 알파벳의 크기로 대입함 
7131
zaba

Step 3)
-> 7131을 desc sort 하면 7311 > 가장 큰 값은 7 
제일 큰 글자의 높이는 7이 됨.

Step 4)
(글자수) * (1mm 가로사이즈 * 제일 큰 세로 사이즈 글씨)
4 * (1 * 7)

4 * 7 = 28


*/
function designerPdfViewer(h, word) {
    // Complete this function
    // 알파벳 잘라 넣기
    var alp = 'abcdefghijklmnopqrstuvwxyz'.split('');
    // 알파벳의 위치값 처리하는 배열 선언 
    var chkVal = [];
    // 입력된 텍스트 길이만큼 포문 
    for (var i = 0 ; i < word.length ; i++){
        //초기값 설정 
        chkVal[i] = 0;
        //26개 글자 만큼 돌리기
        for (var j = 0 ; j < 26 ; j++){
            // 입력한 글자와 alp 배열의 글자가 같다면.
            if (word[i] == alp[j]){
                //console.log(word[i])
                //console.log(alp[j])
                //console.log(j);
                //그 값의 위치를 숫자로 입력 
                //chkVal[i] = j;
                //해당 위치의 h배열에 담긴 값을 chkVal 배열에 넣기
                chkVal[i] = h[j];
            }
        }
    }
    //desc sort 처리 후 가장 큰 값 [0]번 가저오기
    var MaxHeight = chkVal.sort(function(a, b){return b-a})[0];
    //결과 대입 -> 입력한글자수 * (1mm * 가장 높은값);
    var result = word.length * (1 * MaxHeight);
    return result
}

function main() {
    // 1번 라인 h에 넣기 
    h = readLine().split(' ');
    // 1번 라인 h에 맵으로 정렬
    h = h.map(Number);
    // 2번 라인 word 로 입력 
    var word = readLine();
    // 함수 호출 
    var result = designerPdfViewer(h, word);
    process.stdout.write("" + result + "\n");

}