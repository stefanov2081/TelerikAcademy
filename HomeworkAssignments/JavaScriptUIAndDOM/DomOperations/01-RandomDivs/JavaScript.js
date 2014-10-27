function main() {
    var count = parseInt(document.getElementById("count").value);

    var docFragment = document.createDocumentFragment();
    var div = document.createElement("div");
    var strong = document.createElement("strong");
    strong.innerText = "DIV";
    div.appendChild(strong);
    div.style.textAlign = "center";
    var red = "";
    var green = "";
    var blue = "";

    for (var i = 0; i < count; i++) {
        div = div.cloneNode(true);
        div.style.width = generateRandomNumber(20, 100) + "px";
        div.style.height = generateRandomNumber(20, 100) + "px";

        red = generateRandomNumber(0, 255);
        green = generateRandomNumber(0, 255);
        blue = generateRandomNumber(0, 255);
        div.style.backgroundColor = "rgb(" + red + "," +  green + ", " + blue + ")";

        red = generateRandomNumber(0, 255);
        green = generateRandomNumber(0, 255);
        blue = generateRandomNumber(0, 255);
        div.style.color = "rgb(" + red + "," + green + ", " + blue + ")";

        div.style.position = "relative";
        div.style.left = generateRandomNumber(10, 200) + "px";               
        
        red = generateRandomNumber(0, 255);
        green = generateRandomNumber(0, 255);
        blue = generateRandomNumber(0, 255);
        div.style.border = generateRandomNumber(10, 20) + "px solid" + "rgb(" + red + "," + green + ", " + blue + ")";

        div.style.borderRadius = generateRandomNumber(10, 75) + "px";

        docFragment.appendChild(div);
    }

    document.body.appendChild(docFragment);
}

function generateRandomNumber(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
}