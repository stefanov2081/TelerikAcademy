function onButtonClick(event, arguments) {
    var clientWindow = window,
        clientBrowser = clientWindow.navigator.appCodeName,
        isMozilla = clientBrowser === "Mozilla";

    if (isMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}