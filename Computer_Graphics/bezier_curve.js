var canvas = document.getElementById('myCanvas');
var context = canvas.getContext('2d');

context.beginPath();
context.moveTo(x=20, y=200);
context.bezierCurveTo(
        cp1x=700, cp1y=50, 
        cp2x=200, cp2y=50, 
        x=570, y=200
    );
context.lineWidth=15;
context.strokeStyle='green';
context.stroke();




