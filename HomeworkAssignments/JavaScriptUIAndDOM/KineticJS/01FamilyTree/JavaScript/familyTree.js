/*global document: false */
/*global location: false */
/*global Kinetic: false */

function getWidth(finalArr) {
    "use strict";

    var width,
        i,
        maxLength = 0;

    for (i = 0; i < finalArr.length; i += 1) {

        if (finalArr[i].length > maxLength) {
            maxLength = finalArr[i].length;
        }
    }

    width = maxLength * 350;

    return width;
}

function line(row, parrent) {
    "use strict";

    var i,
        j;

    for (i = 0; i < row.length; i += 1) {
        for (j = 0; j < row[i].children.length; j += 1) {

            if (parrent === row[i].children[j]) {
                return i;
            }
        }
    }
    return -1;
}

function print(finalArr) {
    "use strict";

    var stage,
        layer,
        x = 50,
        y = 50,
        row,
        members,
        hasMother,
        hasFather,
        motherChild,
        fatherChild,
        rectM,
        nameM,
        rectF,
        nameF,
        x1,
        y1,
        x2,
        y2,
        straight,
        headlen,
        angle;

    stage = new Kinetic.Stage({
        container: 'canvas-container',
        width: getWidth(finalArr),
        height: finalArr.length * 110
    });

    layer = new Kinetic.Layer();

    for (row = 0; row < finalArr.length; row += 1) {
        for (members = 0; members < finalArr[row].length; members += 1) {

            hasMother = finalArr[row][members].mother !== undefined;
            hasFather = finalArr[row][members].father !== undefined;

            if (hasMother && (row - 1 >= 0)) {
                motherChild = line(finalArr[row - 1], finalArr[row][members].mother);
            } else {
                motherChild = -1;
            }

            if (hasFather && (row - 1 >= 0)) {
                fatherChild = line(finalArr[row - 1], finalArr[row][members].father);
            } else {
                fatherChild = -1;
            }

            if (hasMother) {
                rectM = new Kinetic.Rect({
                    x: x,
                    y: y,
                    width: 200,
                    height: 25,
                    stroke: 'purple',
                    strokeWidth: 2,
                    tension: 0.5
                });

                nameM = new Kinetic.Text({
                    x: rectM.getX(),
                    y: rectM.getY(),
                    text: finalArr[row][members].mother,
                    fontSize: 24,
                    fontFamily: 'Calibri',
                    width: rectM.getWidth(),
                    align: 'center',
                    fill: 'green'
                });
                layer.add(rectM);
                layer.add(nameM);

            }
            if (motherChild !== -1) {
                x1 = 50 + (200 * (motherChild + 1) + (50 * motherChild));
                y1 = y - 75;
                x2 = x + 100;
                y2 = y;
                headlen = 10;
                angle = Math.atan2(y2 - y1, x2 - x1);

                straight = new Kinetic.Line({
                    points: [x1, y1, x2, y2, x2 - headlen * Math.cos(angle - Math.PI / 6),
                        y2 - headlen * Math.sin(angle - Math.PI / 6), x2, y2, x2 - headlen * Math.cos(angle + Math.PI / 6),
                        y2 - headlen * Math.sin(angle + Math.PI / 6)],
                    stroke: 'green',
                    strokeWidth: 2
                    //lineJoin: 'round'
                });
                layer.add(straight);
            }

            if (hasMother) {
                x += 200;
            }

            if (hasFather) {
                rectF = new Kinetic.Rect({
                    x: x,
                    y: y,
                    width: 200,
                    height: 25,
                    stroke: 'blue',
                    strokeWidth: 2,
                    tension: 0.5
                });

                nameF = new Kinetic.Text({
                    x: rectF.getX(),
                    y: rectF.getY(),
                    text: finalArr[row][members].father,
                    fontSize: 24,
                    fontFamily: 'Calibri',
                    width: rectF.getWidth(),
                    align: 'center',
                    fill: 'green'
                });
                layer.add(nameF);
                layer.add(rectF);
            }

            if (fatherChild !== -1) {
                x1 = 50 + (200 * (fatherChild + 1) + (50 * fatherChild));
                y1 = y - 75;
                x2 = x + 100;
                y2 = y;
                headlen = 10;
                angle = Math.atan2(y2 - y1, x2 - x1);

                straight = new Kinetic.Line({
                    points: [x1, y1, x2, y2, x2 - headlen * Math.cos(angle - Math.PI / 6),
                        y2 - headlen * Math.sin(angle - Math.PI / 6), x2, y2, x2 - headlen * Math.cos(angle + Math.PI / 6),
                        y2 - headlen * Math.sin(angle + Math.PI / 6)],
                    stroke: 'green',
                    strokeWidth: 2
                });
                layer.add(straight);
            }

            if (hasFather) {
                x += 200;
            }

            x += 50;
            stage.add(layer);
        }

        x = 50;
        y += 100;
    }

}

function contains(arr, obj) {
    "use strict";

    var i;

    for (i = 0; i < arr.length; i += 1) {

        if (arr[i] === obj) {
            return true;
        }
    }

    return false;
}

function getFirstParents(arr) {
    "use strict";

    var i,
        j,
        n,
        parentsArray = [],
        currentObject,
        indexesToDelete = [],
        isChild = false;

    for (i = 0; i < arr.length; i += 1) {

        currentObject = arr[i];

        for (j = 0; j < arr.length; j += 1) {

            if (contains(arr[j].children, currentObject.father) || contains(arr[j].children, currentObject.mother)) {

                isChild = true;
                break;
            }
        }

        if (!isChild) {

            parentsArray.push(currentObject);
            indexesToDelete.push(i);
            //arr.splice(i, 1);
        }

        isChild = false;
    }

    for (n = indexesToDelete.length - 1; n >= 0; n -= 1) {
        arr.splice(indexesToDelete[n], 1);
    }

    return parentsArray;
}

function getCurrentBranch(arr, parentsArr) {
    "use strict";

    var i,
        j,
        k,
        currentChild,
        currentBranchArr = [],
        isParent = false;

    for (i = 0; i < parentsArr.length; i += 1) {

        for (j = 0; j < parentsArr[i].children.length; j += 1) {

            currentChild = parentsArr[i].children[j];

            for (k = 0; k < arr.length; k += 1) {
                if (arr[k].mother === currentChild || arr[k].father === currentChild) {

                    currentBranchArr.push(arr[k]);
                    arr.splice(k, 1);
                    isParent = true;
                    break;
                }
            }

            if (!isParent) {
                if (currentChild[currentChild.length - 1] === "a") {
                    currentBranchArr.push({
                        mother: currentChild,
                        father: undefined,
                        children: []
                    });
                } else {
                    currentBranchArr.push({
                        mother: undefined,
                        father: currentChild,
                        children: []
                    });
                }
            }
            isParent = false;
        }
    }

    return currentBranchArr;
}

function main() {
    "use strict";

    var parentsArray = [],
        familyMembers;



    // Test data
    familyMembers = [{
        mother: 'Maria Petrova',
        father: 'Georgi Petrov',
        children: ['Teodora Petrova', 'Peter Petrov']
    }, {
        mother: 'Elena Pundiova',
        father: 'Marian Pundiov',
        children: ['Kamen Pundiov', 'Hristina Ivancheva']
    }, {
        mother: 'Petra Stamatova',
        father: 'Todor Stamatov',
        children: ['Teodor Stamatov', 'Boris Opanov', 'Maria Petrova']
    }, {
        mother: 'Dobrinka Pundiova',
        father: 'Georgi Pundiov',
        children: ['Pavel Pundiov', 'Marian Pundiov']
    }, {
        mother: 'Donika Dimitrova',
        father: 'Doncho Dimitrov',
        children: ['Vladimir Dimitrov', 'Iliana Dobreva']
    }, {
        mother: 'Juliana Petrova',
        father: 'Peter Petrov',
        children: ['Dimitar Petrov', 'Galina Opanova']
    }, {
        mother: 'Galina Hristova',
        father: 'Marin Hristov',
        children: ['Petar Hristov', 'Kamen Hristov', 'Ivan Hristov']
    }, {
        mother: 'Iliana Dobreva',
        father: 'Delian Dobrev',
        children: ['Dimitar Dobrev', 'Galina Pundiova']
    }, {
        mother: 'Boriana Stamatova',
        father: 'Teodor Stamatov',
        children: ['Martin Stamatov', 'Albena Dimitrova']
    }, {
        mother: 'Galina Pundiova',
        father: 'Martin Pundiov',
        children: ['Dimitar Pundiov', 'Todor Pundiov']
    }, {
        mother: 'Maria Pundiova',
        father: 'Dimitar Pundiov',
        children: ['Georgi Pundiov', 'Stoian Pundiov']
    }, {
        mother: 'Hristina Ivancheva',
        father: 'Martin Ivanchev',
        children: ['Kamen Ivanchev', 'Evgeny Ivanchev']
    }, {
        mother: 'Maria Ivancheva',
        father: 'Kamen Ivanchev',
        children: ['Ivo Ivanchev', 'Delian Ivanchev']
    }, {
        mother: 'Nadejda Ivancheva',
        father: 'Ivo Ivanchev',
        children: ['Petio Ivanchev', 'Marin Ivanchev']
    }, {
        mother: 'Natalia Ivancheva',
        father: 'Delian Ivanchev',
        children: ['Galina Hristova']
    }, {
        mother: 'Albena Dimitrova',
        father: 'Ivan Dimitrov',
        children: ['Doncho Dimitrov', 'Ivaylo Dimitrov']
    }, {
        mother: 'Galina Opanova',
        father: 'Boian Opanov',
        children: ['Maria Opanova', 'Patar Opanov']
    }, {
        mother: 'Simona Hristova',
        father: 'Kamen Hristov',
        children: ['Elena Hristova', 'Valeria Hristova']
    }];

    parentsArray.push(getFirstParents(familyMembers));

    while (familyMembers.length > 0) {

        parentsArray.push(getCurrentBranch(familyMembers, parentsArray[parentsArray.length - 1]));
        //familyMembers.pop();
    }

    parentsArray.push(getCurrentBranch(familyMembers, parentsArray[parentsArray.length - 1]));
    print(parentsArray);
}
