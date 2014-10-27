/*global document: false */
/*global location: false */

function drawBall(ctx, x, y, r) {
    "use strict";

    ctx.strokeStyle = '#ce2626';
    ctx.fillStyle = 'rgba(155, 250, 10, 0.5)';

    ctx.beginPath();
    ctx.arc(x + r, y + r, r, 0, 2 * Math.PI);
    ctx.closePath();
    ctx.fill();
    ctx.stroke();
}

function animate(x, y, r, canvas, ctx, speedX, speedY) {
    "use strict";

    // update

    // pixels / second
    //if (x < canvas.width - x + r) {
    //    var newX = linearSpeedX * time / 1000;
    //    var newY = linearSpeedY * time / 1000;
    //}

    if (x < 0 || x + r + r > canvas.width) {
        speedX *= -1;
    }
    
    if (y < 0 || y + r + r > canvas.height) {
        speedY *= -1;
    }

    x += speedX;
    y += speedY;

    //if (newX < canvas.width - x + r) {
    //    x = newX;
    //}

    //if (newX > canvas.width - x + r) {
    //    linearSpeedX *= -1;
    //}

    // clear
    ctx.clearRect(x - r / 2, y - r / 2, r * 4, r * 4);

    drawBall(ctx, x, y, r);

    // request new frame
    requestAnimFrame(function () {
        animate(x, y, r, canvas, ctx, speedX, speedY);
    });
}

function main() {
    "use strict";

    var canvas, ctx;

    canvas = document.getElementById('canvas');
    ctx = canvas.getContext('2d');

    //gradient = ctx.createRadialGradient(75, 50, 5, 90, 60, 100);
    //gradient.addColorStop(0, '#f00');
    //gradient.addColorStop(1, '#fff');




    // Background
    //ctx.fillStyle = '#fff';
    //ctx.fillRect(0, 0, canvas.width, canvas.height);

    // Ball
    //gradient = ctx.createRadialGradient(75, 50, 5, 90, 60, 100);
    //gradient.addColorStop(0, '#f00');
    //gradient.addColorStop(1, '#fff');

    //ctx.strokeStyle = '#ce2626';
    //ctx.fillStyle = gradient;

    //ctx.beginPath();
    //ctx.arc(x + r, y + r, r, 0, 2 * Math.PI);
    //ctx.closePath();
    //ctx.fill();
    //ctx.stroke();

    //ctx.clearRect(0, 0, canvas.width, canvas.height);

    window.requestAnimFrame = (function (callback) {
        return window.requestAnimationFrame || window.webkitRequestAnimationFrame || window.mozRequestAnimationFrame ||
            window.oRequestAnimationFrame || window.msRequestAnimationFrame || function (callback) {
                window.setTimeout(callback, 1000 / 60);
            };
    })();

    animate(0, 0, 50, canvas, ctx, 10, 10);
}