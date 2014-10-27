﻿//Telerik
var paperT = Raphael(10, 10, 400, 200);

var telerikLogo = paperT.path("M10 30 L30 10 L70 50 L50 70 L30 50 L70 10 L90 30");
telerikLogo.attr({
    "stroke-width": 7,
    stroke: "yellowgreen"
});

var telerik = paperT.text(100, 50, 'Telerik');
telerik.attr({
    "font-weight": "bold",
    "font-size": 70,
    "font-family": "Calibri, Arial",
    "text-anchor": "start"
});

var tradeMark = paperT.text(306, 50, 'R');
tradeMark.attr({
    'font-size': 14,
    'font-weight': 'bold',
    "font-family": "Calibri, Arial",
    "text-anchor": "start"
});
var circleTM = paperT.circle(310, 50, 8);
circleTM.attr({
    'stroke-width': 2
});
var subtext = paperT.text(110, 90, "Develop experiences");
subtext.attr({
    "font-size": 25,
    "font-family": "Calibri, Arial",
    "text-anchor": "start"
});

//YouTube
var paperY = Raphael(10, 200, 300, 100);

var you = paperY.text(10, 40, 'You');
you.attr({
    'font-size': 70,
    "font-family": "Arial Narrow",
    'font-weight': 'bold',
    "text-anchor": "start"
});

var redRect = paperY.rect(120, 0, 150, 80, 20);
redRect.attr({
    fill: 'red',
    stroke: 'red'
});

var tube = paperY.text(130, 40, 'Tube');
tube.attr({
    'font-size': 70,
    "font-family": "Arial Narrow",
    'font-weight': 'bold',
    "text-anchor": "start",
    fill: 'white'
});