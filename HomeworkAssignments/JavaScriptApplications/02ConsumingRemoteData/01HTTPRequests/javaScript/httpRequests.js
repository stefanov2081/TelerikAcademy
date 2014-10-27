/// <reference path="../libs/jquery-2.1.1.js" />
/*global document: false */

var httpRequest = (function () {
    "use strict"

    function ajaxRequests(url, type, dataType, data) {
        "use strict"

        var defer, $ajax;

        defer = new $.Deferred();

        $ajax = $.ajax({
            url: url,
            type: type,
            data: data,
            dataType: dataType,
            success: defer.resolve,
            error: defer.reject
        });

        return $ajax;
    }

    function getJson(url, dataType, data) {
        "use strict"

        return ajaxRequests(url, 'GET', dataType, data);
    }

    function postJson(url, dataType, data) {
        "use strict"

        return ajaxRequests(url, 'POST', dataType, data);
    }

    return {
        getJson: getJson,
        postJson: postJson
    }
}());