var canvas = document.getElementById('splashHomePage');

var df = canvas.getContext('2d');

var x = 25;
var y = 50;
var width = 150;
var height = 200;
var radius = 20;

df.lineWidth = 10;
// top and top right corner
df.moveTo(x + radius, y);
df.arcTo(x + width, y, x + width, y + radius, radius);
// right side and bottom right corner
df.arcTo(x + width, y + height, x + width - radius, y + height, radius);
// bottom and bottom left corner
df.arcTo(x, y + height, x, y + height - radius, radius);
// left and top left corner
df.arcTo(x, y, x + radius, y, radius);
df.stroke();