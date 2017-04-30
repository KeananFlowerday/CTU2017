var canvas;
var ctx;
var down = false;
//change color
var rgbred = 0;
var rgbgreen = 0;
var rgbblue = 0;
var color = 'black'; //line color, default = black
//change line size
var width = 5; //default line width
var colsquare;

//functions
window.onload = function() {
  //sets color of the element
  colsquare = document.getElementById('colsample');
  rgbcolor = "rgb(" + rgbred + "," + rgbgreen + "," + rgbblue + ")";
  colsquare.style.backgroundColor = rgbcolor;

  canvas =document.getElementById('canvas');
  //sets context to 2d
  ctx = canvas.getContext('2d');
  ctx.lineWidth = width;

  //event handlers
  canvas.addEventListener("mousedown", startdraw);
  canvas.addEventListener("mouseup", stopdraw);
  canvas.addEventListener("mousemove", movedraw);
}

function redValue(newcol) {
  rgbred = newcol;
  changesquare();
}

function greenValue(newcol) {
  rgbgreen = newcol;
  changesquare();
}

function blueValue(newcol) {
  rgbblue = newcol;
  changesquare();
}

function changesquare() {
  rgbcolor = "rgb(" + rgbred + "," + rgbgreen + "," + rgbblue + ")";
  colsquare.style.backgroundColor=rgbcolor;

  color = rgbcolor;
}

function startdraw(e) {
  down = true;
  ctx.beginPath();
  ctx.moveTo(xPos, yPos);
}

function movedraw(e) {
  xPos = e.clientX-canvas.offsetLeft;
	yPos = e.clientY-canvas.offsetTop;
	if(down == true)
	{
		ctx.lineTo(xPos,yPos); //create a line from old point to new one
		ctx.strokeStyle = color;
		ctx.stroke();
	}
}

function stopdraw(e) {
  down = false;
}

function clearCanvas() {
  ctx.clearRect(0, 0, canvas.width, canvas.height);
}
