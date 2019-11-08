var canvas = document.getElementById('myCanvas');
var context = canvas.getContext('2d');

context.beginPath();
context.arc(
    x = canvas.width / 2,
    y = canvas.height / 2, 
    radius = 70, 
    Math.PI / 180 * (startAngle=20), 
    Math.PI / 180 * (endAngle = 180), 
    anticlockwise = false
);
context.lineWidth = 15;
context.strokeStyle = 'steelblue';
context.stroke();

