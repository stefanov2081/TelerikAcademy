function main() {
    var bg = document.getElementById("background").value;
    var font = document.getElementById("font").value;

    document.getElementById("text").style.backgroundColor = bg;
    document.getElementById("text").style.color = font;
}