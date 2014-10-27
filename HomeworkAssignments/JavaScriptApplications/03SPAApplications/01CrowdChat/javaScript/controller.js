/// <reference path="view.js" />

var controller = (function () {
    "use strict";

    function getMessage(url, dataType) {
        var chatMessages;

        chatMessages = httpRequest.getJson(url, dataType);

        $.when(chatMessages.done(function () {
            view.printMessages(chatMessages.responseJSON);
            return chatMessages.responseJSON;
        }));

        $.when(chatMessages.fail(function () {
            console.dir(this);
            throw new Error('Query could not be completed. Error #' + chatMessages.status);
        }));
    }

    function postMessage(url, dataType, user, message) {
        var userMessage;

        userMessage = httpRequest.postJson(url, dataType,
            {
                "user": user,
                "text": message
            });

        $.when(userMessage.done(function () {
            console.log(userMessage.responseJSON);
        }));

        $.when(userMessage.fail(function () {
                throw new Error('Query could not be completed. Error #' + userMessage.status);
        }));
    }

    return {
        getMessages: getMessage,
        sendMessage: postMessage,
    };
}());