var constants = (function () {
    "use strict";

    var USER_NAME, URL = 'http://crowd-chat.herokuapp.com/posts';

    function getUserName() {
        constants.USER = $('input').val();
    }

    return {
        getUserName: getUserName,
        USER: USER_NAME,
        URL: URL
    };
}());