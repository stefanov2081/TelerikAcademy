/*global document: false */
/*global location: false */

function main() {
    "use strict";

    var canvas, ctx;

    canvas = document.getElementById('canvas');
    ctx = canvas.getContext('2d');

    // Background
    //ctx.fillStyle = '#fff';
    //ctx.fillRect(0, 0, canvas.width, canvas.height);

    // House main
    ctx.fillStyle = '#9f5656';
    ctx.fillRect(860, 350, 300, 300);
    ctx.strokeRect(860, 350, 300, 300);

    // Windows
    // Left top
    ctx.fillStyle = '#000';
    ctx.strokeStyle = '#9f5656';
    ctx.lineWidth = 5;
    ctx.fillRect(880, 380, 120, 90);
    ctx.strokeRect(880, 380, 120, 90);
    ctx.beginPath();
    ctx.moveTo(940, 380);
    ctx.lineTo(940, 470);
    ctx.moveTo(880, 425);
    ctx.lineTo(1000, 425);
    ctx.stroke();

    // Right top
    ctx.fillRect(1020, 380, 120, 90);
    ctx.strokeRect(1020, 380, 120, 90);
    ctx.beginPath();
    ctx.moveTo(1080, 380);
    ctx.lineTo(1080, 470);
    ctx.moveTo(1020, 425);
    ctx.lineTo(1140, 425);
    ctx.stroke();

    // Right bottom
    ctx.fillRect(1020, 500, 120, 90);
    ctx.strokeRect(1020, 500, 120, 90);
    ctx.beginPath();
    ctx.moveTo(1080, 500);
    ctx.lineTo(1080, 590);
    ctx.moveTo(1020, 545);
    ctx.lineTo(1140, 545);
    ctx.stroke();
    ctx.closePath();

    // Door
    ctx.beginPath();
    ctx.strokeStyle = '#000';
    ctx.moveTo(900, 650);
    ctx.lineTo(900, 540);
    ctx.closePath();

    ctx.stroke();
    ctx.beginPath();
    ctx.moveTo(980, 650);
    ctx.lineTo(980, 540);
    ctx.closePath();
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(980, 540);
    ctx.quadraticCurveTo(940, 480, 900, 540);
    ctx.stroke();
    ctx.closePath();

    ctx.beginPath();
    ctx.moveTo(940, 510);
    ctx.lineTo(940, 650);
    ctx.closePath();
    ctx.stroke();

    ctx.lineWidth = 2;
    ctx.beginPath();
    ctx.arc(925, 600, 5, 0, 2 * Math.PI);
    ctx.closePath();
    ctx.stroke();
    ctx.beginPath();
    ctx.arc(955, 600, 5, 0, 2 * Math.PI);
    ctx.stroke();
    ctx.closePath();

    // Roof
    ctx.save();
    ctx.lineWidth = 5;
    ctx.fillStyle = '#9f5656';
    ctx.beginPath();
    ctx.moveTo(860, 350);
    ctx.lineTo(1010, 150);
    ctx.lineTo(1160, 350);
    ctx.closePath();
    ctx.stroke();
    ctx.fill();

    // Chimney
    ctx.lineWidth = 2;
    ctx.beginPath();
    ctx.moveTo(1050, 280);
    ctx.lineTo(1050, 180);
    ctx.closePath();
    ctx.stroke();

    ctx.fillRect(1050, 180, 40, 100);

    ctx.beginPath();
    ctx.scale(2, 0.5);
    ctx.translate(-530, 175);
    ctx.arc(1065, 180, 10, 0, 2 * Math.PI);
    ctx.fill();
    ctx.closePath();
    ctx.stroke();

    ctx.restore();
    ctx.beginPath();
    ctx.moveTo(1090, 180);
    ctx.lineTo(1090, 280);

    ctx.closePath();
    ctx.stroke();
    ctx.fill();

    // Head
    ctx.save();
    ctx.fillStyle = '#4ca5c2';
    ctx.beginPath();
    ctx.arc(300, 380, 60, 0, 2 * Math.PI);
    ctx.fill();
    ctx.stroke();
    ctx.closePath()

    ctx.restore();

    ctx.save();
    ctx.fillStyle = '#2f5764';
    ctx.beginPath();
    ctx.scale(1, 0.7);
    ctx.arc(270, 510, 10, 0, 2 * Math.PI);
    ctx.stroke();
    ctx.closePath()

    ctx.beginPath();
    ctx.arc(310, 510, 10, 0, 2 * Math.PI);
    ctx.stroke();
    ctx.closePath()

    ctx.restore();
    ctx.save();

    ctx.beginPath();
    ctx.scale(0.4, 1);
    ctx.arc(665, 356, 5, 0, 2 * Math.PI);
    ctx.stroke();
    ctx.fill();
    ctx.closePath()

    ctx.beginPath();
    ctx.arc(765, 356, 5, 0, 2 * Math.PI);
    ctx.stroke();
    ctx.fill();
    ctx.closePath()

    ctx.restore();

    ctx.beginPath();
    ctx.moveTo(290, 360);
    ctx.lineTo(280, 390);
    ctx.lineTo(295, 390);
    ctx.stroke();
    ctx.closePath();

    ctx.save();

    ctx.beginPath();
    ctx.rotate(10 * Math.PI / 180);
    ctx.scale(1, 0.4);
    ctx.arc(360, 890, 25, 0, 2 * Math.PI);
    ctx.stroke();
    ctx.closePath()

    ctx.restore();

    // Hat
    ctx.save();
    ctx.fillStyle = '#2671ce';
    ctx.beginPath();
    ctx.scale(1.5, 0.4);
    ctx.arc(200, 800, 50, 0, 2 * Math.PI);
    ctx.fill();
    ctx.stroke();
    ctx.closePath();

    ctx.restore();
    ctx.save();

    ctx.fillStyle = '#2671ce';
    ctx.beginPath();
    ctx.scale(1, 0.5);
    ctx.arc(300, 610, 40, 0, 2 * Math.PI);
    ctx.fill();
    ctx.stroke();
    ctx.closePath();

    ctx.beginPath();
    ctx.moveTo(260, 610);
    ctx.lineTo(260, 410);
    ctx.lineTo(340, 410);
    ctx.lineTo(340, 610);
    ctx.fill();
    ctx.stroke();
    ctx.closePath();

    ctx.beginPath();
    ctx.scale(1, 0.5);
    ctx.arc(300, 810, 40, 0, 2 * Math.PI);
    ctx.fill();
    ctx.stroke();
    ctx.closePath();

    ctx.restore();

    // Bycicle
    ctx.fillStyle = '#4ca5c2';
    ctx.beginPath();
    ctx.arc(200, 700, 60, 0, 2 * Math.PI);
    ctx.fill();
    ctx.stroke();
    ctx.closePath();

    ctx.beginPath();
    ctx.arc(450, 700, 60, 0, 2 * Math.PI);
    ctx.fill();
    ctx.stroke();
    ctx.closePath();

    ctx.strokeStyle = '#2cd8c3';
    ctx.beginPath();
    ctx.moveTo(200, 700);
    ctx.lineTo(300, 700);
    ctx.lineTo(420, 630);
    ctx.lineTo(280, 630);
    ctx.closePath();
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(450, 700);
    ctx.lineTo(405, 580);
    ctx.lineTo(370, 610);
    ctx.moveTo(405, 580);
    ctx.lineTo(420, 540);
    ctx.closePath();
    ctx.stroke();

    ctx.beginPath();
    ctx.arc(300, 700, 15, 0, 2 * Math.PI);
    ctx.lineTo(335, 705);
    ctx.moveTo(285, 695);
    ctx.lineTo(270, 690);
    ctx.moveTo(300, 700);
    ctx.lineTo(270, 600);
    ctx.moveTo(290, 600);
    ctx.lineTo(250, 600);
    ctx.closePath();
    ctx.stroke();

}