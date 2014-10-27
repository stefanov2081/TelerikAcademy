/// <reference path="../libs/jquery-2.1.1.js" />
/// <reference path="constants.js" />
/// <reference path="controller.js" />
/* global document: false */

var view = (function () {
    "use strict";
    var reloadInterval;


    // Draw all messages in #main-container
    function printMessages(messages) {
        var ul = $('<ul>')

        for (var i = 0; i < messages.length; i += 1) {
            ul.append('<li><p>' + messages[i].title + '</p>' +
                '<p>' + messages[i].body + '</p></li>');
        }

        $('#main-container').empty();
        $('#main-container').append(ul);
    }

    // Fetch all messages from the server every n seconds
    function reloadChatScreen() {
        reloadInterval = setInterval(function () {

            var name, pattern, nameAndPattern;

            name = $('#name:checked').length <= 0;
            pattern = $('#pattern:checked').length <= 0;
            nameAndPattern = $('#name-pattern:checked').length <= 0;

            if (name && pattern && nameAndPattern) {
                controller.getMessages(constants.URL, 'json');
                console.log('in here');

            } else if ($('#name:checked').length > 0) {
                controller.getMessagesFilteredByName(constants.URL_FILTER_BY_USER_NAME, (constants.USER.toLowerCase()));
            }
            if ($('#pattern:checked').length > 0) {
                controller.getMessagesFilteredByPattern(constants.URL_FILTERED_BY_PATTERN, ($('input').val().toLowerCase()));
            }
            if ($('#name-pattern:checked').length > 0) {
                controller.getMessagesFilteredByNameAndPattern(constants.URL_FILTERED_BY_PATTERN,
                ($('input').val().toLowerCase()), ($('input').val().toLowerCase()));
            }
        }, 1000)
    }

    //Draw guest chat screen
    function drawGuestScreen() {
        $('#main-container').empty();
        reloadChatScreen();
    }

    // Draw the chat screen
    function drawChatScreen() {
        var $input, $button, $buttonLogout, $filterByName, $filterByPattern, $filterByNameAndPattern, $labelForName, $labelForPattern, $labelForNameAndPattern;

        $('#main-container').empty();
        $input = $('<input type="text" class="message-input" />');
        $button = $('<input type="button" class="message-button" value="Send Message">');
        $buttonLogout = $('<input type="button" class="message-button" value="Log Out">');
        $button.on('click', function () {
            controller.sendMessage(constants.URL_POST, 'json', constants.USER, $('input').val(), constants.SESSION_KEY);
            controller.getMessages(constants.URL_POST, 'json');
            $input.empty();
        });
        $buttonLogout.on('click', function () {
            controller.logOutUser(constants.URL_USER, 'json', constants.SESSION_KEY);
            clearInterval(reloadInterval);
            view.drawLogOutScreen();
        });
        $input.on('keypress', function (enter) {
            if (enter.which == 13) {
                controller.sendMessage(constants.URL_POST, 'json', constants.USER, $('input').val(), constants.SESSION_KEY);
                controller.getMessages(constants.URL_POST, 'json');
                $input.val('');
            }
        });

        $filterByName = $('<input type="checkbox" name="name" id="name" />');
        $filterByName.on('click', function () {
            controller.getMessagesFilteredByName(constants.URL_FILTER_BY_USER_NAME, (constants.USER.toLowerCase()));
        });
        $filterByPattern = $('<input type="checkbox" name="pattern" id="pattern" />');
        $filterByPattern.on('click', function () {
            controller.getMessagesFilteredByPattern(constants.URL_FILTERED_BY_PATTERN, ($('input').val().toLowerCase()));
        });
        $filterByNameAndPattern = $('<input type="checkbox" name="name-pattern" id="name-pattern" />');
        $filterByNameAndPattern.on('click', function () {
            controller.getMessagesFilteredByNameAndPattern(constants.URL_FILTERED_BY_PATTERN,
                ($('input').val().toLowerCase()), ($('input').val().toLowerCase()));
        });
        $labelForName = $('<label for="name">Filter by Name </label>');
        $labelForPattern = $('<label for="pattern">Filter by Pattern </label>');
        $labelForNameAndPattern = $('<label for="name-pattern">Filter by Name and Pattern </label>');


        $input.insertAfter('#main-container');
        $button.insertAfter($input);
        $buttonLogout.insertAfter($button);
        $labelForName.insertAfter($buttonLogout);
        $filterByName.insertAfter($labelForName);
        $labelForPattern.insertAfter($filterByName);
        $filterByPattern.insertAfter($labelForPattern);
        $labelForNameAndPattern.insertAfter($filterByPattern);
        $filterByNameAndPattern.insertAfter($labelForNameAndPattern);
        reloadChatScreen();
    }

    // Draw user name input field screen
    function drawUserNameInputScreen(onClick, onEnter) {
        var $mainContainer, $paragraph, $input, $password, $button;

        $mainContainer = $('#main-container');
        $paragraph = $('<h1>Enter user name and password:</h1>');
        $input = $('<input type="text" id="input-user-name" placeholder="User name"/>');
        $password = $('<input type="password" id="input-password" placeholder="Password"/>');
        $button = $('<input type="button" value="Enter Chat">');
        $button.on('click', onClick);

        $mainContainer.append($mainContainer, $paragraph);
        $mainContainer.append($input);
        $mainContainer.append($password);
        $mainContainer.append($button);
    }

    // Draw logout screen
    function drawLogOutScreen() {
        $('#main-container').empty().append('<h1>You have logged out</h1>');

        var $button = $('<input type="button" value="Home">');
        $button.on('click', view.run());

    }

    // Draw welcome screen
    function drawWelcomeScreen() {
        var $mainContainer, $header, $inputGuest, $inputLogin, $inputRegister, $buttonGuest, $buttonLogin, $buttonRegister;

        $mainContainer = $('#main-container');
        $header = $('<h1>Welcome to the chat. You can login in, register or enter as guest!</h1>');

        // Guest input field
        //$inputGuest = $('<input type="text" id="input-guest" />');
        $buttonGuest = $('<input type="button" value="Enter as Guest">');
        $buttonGuest.on('click', function () {
            view.drawGuestChatScreen();
        });

        // Login input field
        $buttonLogin = $('<input type="button" value="Log In">');
        $buttonLogin.on('click', function () {
            drawUserNameInputScreen(function () {
                constants.getUserName();
                constants.getPassword();
                controller.logInUser(constants.URL_LOG_IN, 'json', constants.USER, constants.USER_PASSWORD);
                view.drawChatScreen();
            });
        });

        // Register input field
        $buttonRegister = $('<input type="button" value="Register">');
        $buttonRegister.on('click', function () {
            drawUserNameInputScreen(function () {
                constants.getUserName();
                constants.getPassword();
                controller.registerUser(constants.URL_USER, 'json', constants.USER, constants.USER_PASSWORD);
                view.drawChatScreen();
            });
        });

        // Append all input fields to main container
        $mainContainer.append($header);
        $mainContainer.append($buttonGuest);
        $mainContainer.append($buttonLogin);
        $mainContainer.append($buttonRegister);

    }

    function run() {
        drawWelcomeScreen();
    }

    return {
        drawChatScreen: drawChatScreen,
        drawGuestChatScreen: drawGuestScreen,
        drawUserNameInputScreen: drawUserNameInputScreen,
        drawLogOutScreen: drawLogOutScreen,
        drawWelcomeScreen: drawWelcomeScreen,
        printMessages: printMessages,
        run: run,
    };
}());