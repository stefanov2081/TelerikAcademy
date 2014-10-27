var constants = (function () {
    "use strict";

    var USER_NAME,
        USER_PASS,
        SESS_KEY,
        URL = 'http://jsapps.bgcoder.com/post',
        LOCAL_URL = 'http://localhost:3000/post',
        URL_AUTH = 'http://jsapps.bgcoder.com/auth',
        URL_POST = 'http://jsapps.bgcoder.com/post',
        URL_USER = 'http://jsapps.bgcoder.com/user',
        URL_FILTER_BY_USER = 'http://jsapps.bgcoder.com/post?user=',
        URL_FILTER_BY_PATTERN = 'http://jsapps.bgcoder.com/post?pattern=';

    function getUserName() {
        constants.USER = $('#input-user-name').val();
    }

    function getPassword() {
        constants.USER_PASSWORD = $('#input-password').val();
    }

    function getSessionKey(sessionKey) {
        constants.SESSION_KEY = sessionKey;
    }

    return {
        getUserName: getUserName,
        getPassword: getPassword,
        getSessionKey: getSessionKey,
        USER: USER_NAME,
        USER_PASSWORD: USER_PASS,
        URL: URL,
        URL_USER: URL_USER,
        URL_LOG_IN: URL_AUTH,
        URL_POST: URL_POST,
        URL_FILTER_BY_USER_NAME: URL_FILTER_BY_USER,
        URL_FILTERED_BY_PATTERN: URL_FILTER_BY_PATTERN,
        SESSION_KEY: SESS_KEY
    };
}());