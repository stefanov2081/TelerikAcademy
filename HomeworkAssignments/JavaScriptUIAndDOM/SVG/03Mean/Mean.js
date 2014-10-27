﻿var svgNS = 'http://www.w3.org/2000/svg';
var svg = document.createElementNS(svgNS, 'svg');
svg.setAttribute('width', '500');
svg.setAttribute('height', '500');
document.body.appendChild(svg);

var repetitionsCount = 4;
var circleStartX = 250;
var textStartX = 120;
var startY = 100;
var radius = 60;
var fontSize = '40px';
var colors = ['grey', 'black', 'red', 'yellowgreen', 'green'];
var word = ['MEAN', 'express'];
var OrderedFunctions = [
    function drawLeaf() {
        drawPath('yellowgreen', 'yellowgreen', 'M 250 80 C220 100 250 130 250 130', 1);
        drawPath('green', 'green', 'M  250 80 C280 100 250 130 250 130', 1);
    },
    function drawExpress() {
        writeTextOnThePage(205, 180, 24, 'white', word[1], 'Consolas');
    },
    function drawAngularJs() {
        drawPath('darkred', 'lightgrey', 'M 250 220 L270 230 L250 300', 2);
        drawPath('red', 'lightgrey', 'M 250 220 L230 230 L250 300', 2);
        drawPath('red', 'white', 'M 250 230 L230 280', 3);
        drawPath('red', 'lightgrey', 'M 250 230 L270 280', 3);

    }
];

function createCircle(x, y, r, fill) {
    var circle = document.createElementNS(svgNS, 'circle');
    circle.setAttribute('cx', x);
    circle.setAttribute('cy', y);
    circle.setAttribute('r', r);
    circle.setAttribute('stroke', 'none');
    circle.setAttribute('fill', fill);

    svg.appendChild(circle);
}

function writeTextOnThePage(x, y, fontSize, color, innerText, fontFamily) {
    var text = document.createElementNS(svgNS, 'text');
    text.setAttribute('x', x);
    text.setAttribute('y', y);
    text.setAttribute('font-size', fontSize);
    text.setAttribute('fill', color);
    text.setAttribute('font-family', fontFamily),
    text.innerHTML = innerText;
    svg.appendChild(text);

}

function drawPath(fillColor, strokeColor, d, strokeWidth) {
    var leftCurve = document.createElementNS(svgNS, 'path');
    leftCurve.setAttribute('d', d);
    leftCurve.setAttribute('fill', fillColor);
    leftCurve.setAttribute('stroke', strokeColor);
    leftCurve.setAttribute('stroke-width', strokeWidth);
    svg.appendChild(leftCurve);
}

for (var i = 0; i < repetitionsCount; i++) {
    createCircle(circleStartX, startY, radius, colors[i]);
    writeTextOnThePage(textStartX, startY, fontSize, colors[i], word[0][i], 'Consolas');
    if (OrderedFunctions[i]) {
        OrderedFunctions[i]();
    }
    startY += 70;
}

