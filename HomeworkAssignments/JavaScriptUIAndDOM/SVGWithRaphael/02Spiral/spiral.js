﻿var paperS = Raphael('svg', 400, 300);

function drawSpiral(centerX, centerY, a, b) {
    var centralPoint = "M" + centerX + ' ' + centerY,
        spiralPoints = [centralPoint];

    for (var i = 0; i < 720; i++) {
        var angle = 0.1 * i,
            x = centerX + (a + b * angle) * Math.cos(angle),
            y = centerY + (a + b * angle) * Math.sin(angle);

        spiralPoints.push('L ' + x + ' ' + y);

    }
    var spiralPointsStr = spiralPoints.join(' '),
    spiral = paperS.path(spiralPointsStr);
}

drawSpiral(250, 150, 0, 2);