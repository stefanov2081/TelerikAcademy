/// <reference path="../libs/sha1.js" />
/// <reference path="httpRequests.js" />
/// <reference path="view.js" />

var controller = (function () {
    "use strict";

    // Fetches all messages from the server
    function getMessage(url, dataType) {
        var chatMessages;

        chatMessages = httpRequest.getJson(url, dataType);

        $.when(chatMessages.done(function () {
            view.printMessages(chatMessages.responseJSON);
            console.log(chatMessages.responseJSON);
            return chatMessages.responseJSON;
        }));

        $.when(chatMessages.fail(function (promise) {
            console.dir(this);
            console.log(promise);
            throw new Error('Query could not be completed. Error #' + chatMessages.status);
        }));
    }

    // Posts new message to server
    function postMessage(url, dataType, user, message, sessionKey) {
        var userMessage;

        userMessage = httpRequest.postJson(url, dataType,
            {
                "title": user,
                "body": message
            }, {
                'X-SessionKey': sessionKey
            });

        $.when(userMessage.done(function () {
            console.log(userMessage.responseJSON);
            console.log(this);
        }));

        $.when(userMessage.fail(function () {
            console.log(this)
            throw new Error('Query could not be completed. Error #' + userMessage.status);
        }));
    }

    // Register a new user
    function registerUser(url, dataType, userName, password) {
        var registered,
            hashedAuthCode = CryptoJS.SHA1(userName + password);

        registered = httpRequest.postJson(url, dataType,
            {
                "username": userName,
                "authCode": hashedAuthCode.toString()
            });

        $.when(registered.done(function () {
            controller.logInUser(constants.URL_LOG_IN, 'json', constants.USER, constants.USER_PASSWORD);
            console.log(registered.responseJSON);
        }));

        $.when(registered.fail(function (promise) {
            console.log(promise.responseJSON.message);

            throw new Error('Query could not be completed. Error #' + registered.status);
        }));
    }

    // Log in existing user
    function logInUser(url, dataType, userName, password) {
        var loggedIn,
            hashedAuthCode = CryptoJS.SHA1(userName + password);

        loggedIn = httpRequest.postJson(url, dataType,
            {
                "username": userName,
                "authCode": hashedAuthCode.toString()
            })

        $.when(loggedIn.done(function () {
            constants.getSessionKey(loggedIn.responseJSON.sessionKey);
            console.log(constants.USER);
            console.log(constants.USER_PASSWORD);
            console.log(constants.SESSION_KEY);


            console.log(loggedIn.responseJSON.sessionKey);
        }));

        $.when(loggedIn.fail(function (promise) {
            console.log(promise.responseJSON.message);
            console.dir(promise.responseJSON);
            console.log(constants.USER);
            console.log(constants.USER_PASSWORD);
            console.log(constants.SESSION_KEY);
            throw new Error('Query could not be completed. Error #' + loggedIn.status);
        }));
    }

    // Log out user
    function logOutUser(url, dataType, sessionKey) {
        var loggedOut = httpRequest.customMethodRequest(url, 'PUT', dataType, undefined,
            {
                'X-SessionKey': sessionKey
            });

        $.when(loggedOut.done(function () {
            console.log(loggedOut.responseJSON);
        }));

        $.when(loggedOut.fail(function (promise) {
            console.log(promise.responseJSON.message);
            console.dir(promise.responseJSON);
            throw new Error('Query could not be completed. Error #' + loggedOut.status);
        }));
    }

    function getMessagesFilteredByUserName(url, userName) {
        controller.getMessages((url + userName.toLowerCase()), 'json');
    }

    function getMessagesFilteredByPattern(url, pattern) {
        controller.getMessages((url + pattern.toLowerCase()), 'json');
    }

    function getMessagesFilteredByUserAndPattern(url, userName, pattern) {
        controller.getMessages((url + pattern.toLowerCase()) + '&user=' + (userName.toLowerCase()));
    }

    return {
        getMessages: getMessage,
        getMessagesFilteredByName: getMessagesFilteredByUserName,
        getMessagesFilteredByPattern: getMessagesFilteredByPattern,
        getMessagesFilteredByNameAndPattern: getMessagesFilteredByUserAndPattern,
        sendMessage: postMessage,
        registerUser: registerUser,
        logInUser: logInUser,
        logOutUser: logOutUser
    };
}());