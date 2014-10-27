/// <reference path="../libs/q.js" />
/*global document: false */

var httpRequest = (function () {
    "use strict"

    function getJson(url) {
        "use strict"

        var httpRequest, deferred;

        deferred = Q.defer();

        httpRequest = new XMLHttpRequest();


        httpRequest.onreadystatechange = function () {
            if (httpRequest.status === '200') {
                if (httpRequest.readyState === '4') {

                    console.log(httpRequest.responseText);
                    return deferred.promise(httpRequest.responseText);
                }
            } else {
                return deferred.reject(httpRequest.responseText);
            }
        };

        httpRequest.open('GET', url, true);
        httpRequest.send(null);

        return deferred.promise;
    }

    function postJson(url, jsonObject) {
        "use strict"
    }

    return {
        getJson: getJson,
        postJson: postJson
    }
}());