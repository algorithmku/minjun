/*
Cavity Map 
https://www.hackerrank.com/challenges/cavity-map/problem
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

function cavityMap(grid) {
    // Complete this function
    /*
    
    상하좌우 값을 비교하여 X로 변환함. (대각선은 X)
    
    */
    if (grid.length > 2){

        var now_num = 0;
        var up_num = 0;
        var down_num = 0;
        var right_num = 0;
        var left_num = 0;

        for (var i = 1 ; i < grid.length-1 ; i++){
            for (var j = 1 ; j < grid.length-1 ; j++){

                now_num = grid[i][j];
                up_num = grid[i-1][j];
                down_num = grid[i+1][j];    
                left_num = grid[i][j-1];
                right_num = grid[i][j+1];
                
                if (now_num > up_num && now_num > down_num && now_num > right_num && now_num > left_num){
                    //console.log(grid[i][j] + " = " + i + "," +j);
                    var arr = grid[i].split("");
                    arr.splice(j, 1, 'X');
                    grid[i] = arr.join("");
                    //console.log(grid[i][j]);
                }else{
                    //console.log(grid[i][j]);
                }
            }   
        }
        return grid;
    }else{
        return grid;
    }
}

function main() {
    var n = parseInt(readLine());
    var grid = [];
    for(var grid_i = 0; grid_i < n; grid_i++){
       grid[grid_i] = readLine();
    }
    var result = cavityMap(grid);
    console.log(result.join("\n"));



}