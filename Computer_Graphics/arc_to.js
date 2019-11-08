var canvas = document.getElementById('myCanvas');
var context = canvas.getContext('2d');

context.beginPath();
context.arcTo(
    x1 = 100, y1 = 50, 
    x2 = 400, y2 = 90, 
    radius = 150
);
context.strokeStyle='pink';
context.lineWidth=10;
context.stroke();



