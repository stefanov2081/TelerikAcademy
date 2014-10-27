/// <reference path="../libs/jquery-2.1.1.js" />
/// <reference path="constants.js" />
/// <reference path="controller.js" />
/* global document: false */

var view = (function () {
    "use strict";

    function printMessages(messages) {
        var ul = $('<ul>')

        for (var i = 0; i < messages.length; i += 1) {
            ul.append('<li><p>' + messages[i].by + '</p>' +
                '<p>' + messages[i].text + '</p></li>');
        }

        $('#main-container').empty();
        $('#main-container').append(ul);
    }

    function reloadChatScreen() {
        setInterval(function () {
            controller.getMessages(constants.URL, 'json');
        }, 1000)
    }

    function drawChatScreen() {
        var $input, $button;

        $('#main-container').empty();
        $input = $('<input type="text" class="message-input" />');
        $button = $('<input type="button" class="message-button" value="Send Message">');
        $button.on('click', function () {
            controller.sendMessage(constants.URL, 'json', constants.USER, $('input').val());
            controller.getMessages(constants.URL, 'json');
            $input.empty();
        });
        $input.on('keypress', function (enter) {
            if (enter.which == 13) {
                controller.sendMessage(constants.URL, 'json', constants.USER, $('input').val());
                controller.getMessages(constants.URL, 'json');
                $input.val('');
            }
        });
        $input.insertAfter('#main-container');
        $button.insertAfter($input);
        reloadChatScreen();
    }

    function drawUserNameInputScreen() {
        var $mainContainer, $paragraph, $input, $button;

        $mainContainer = $('#main-container');
        $paragraph = $('<h1>Enter user name:</h1>');
        $input = $('<input type="text" />');
        $button = $('<input type="button" value="Enter Chat">');
        $button.on('click', function () {
            constants.getUserName();
            view.drawChatScreen();
        });
        $input.on('keypress', function (enter) {
            if (enter.which == 13) {
                constants.getUserName();
                view.drawChatScreen();
            }
        });
        $mainContainer.append($mainContainer, $paragraph);
        $mainContainer.append($input);
        $mainContainer.append($button);
    }

    function run() {
        drawUserNameInputScreen();
    }

    return {
        run: run,
        drawChatScreen: drawChatScreen,
        printMessages: printMessages
    };
}());