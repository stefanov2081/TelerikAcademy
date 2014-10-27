/*global document: false */

function readInput() {
    "use strict";

    var input = document.getElementById('input').value;

    return input;
}

function print(message) {
    "use strict";

    document.getElementById('list').innerHTML = message;
}

function addToList() {
    "use strict";

    var item, p, list;

    item = readInput();
    list = document.getElementById('list');
    p = document.createElement('p');

    if (item !== ' ' && item !== '') {
        p.textContent = item;
        p.classList.add('list-item');
        p.onclick = function () {
            if (!this.classList.contains('selected')) {
                this.classList.add('selected');
            } else {
                this.classList.remove('selected');
            }
        };

        list.appendChild(p);
    }
}

function removeFromList() {
    "use strict";

    var list, itemsToRemove;

    list = document.getElementById('list');
    itemsToRemove = list.getElementsByClassName('selected');

    while (itemsToRemove.length > 0) {
        list.removeChild(itemsToRemove[0]);
    }
}

function main() {
    "use strict";

    var addButton, removeButton;

    addButton = document.getElementById('add');
    removeButton = document.getElementById('remove');

    addButton.addEventListener('click', addToList, false);
    removeButton.addEventListener('click', removeFromList, false);
}