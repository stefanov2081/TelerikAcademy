/// <reference path="httpRequests.js" />
/// <reference path="../libs/q.js" />
/*global document: false */

(function () {
    "use strict"

    var yourIp;
    Q.fcall(httpRequest.getJson('http://ip.jsontest.com/'))
        .then(function (result) {
            console.log(result);
            yourIp = result;
        }, function (error) {
            console.log(error);
            yourIp = error;
        }, function (progress) {
            console.log(progress);
        });

    console.log(yourIp);
}());