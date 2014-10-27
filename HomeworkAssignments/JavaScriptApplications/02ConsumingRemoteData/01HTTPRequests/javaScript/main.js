/// <reference path="httpRequests.js" />
/// <reference path="../libs/jquery-2.1.1.js" />
/*global document: false */

(function () {
    "use strict"

    var ipUrl, dateTimeUrl, yourIp, dateTime, $div, myServerUrl, dataType = 'json';

    // ipUrl = 'http://ip.jsontest.com/';
	ipUrl = 	'http://crowd-chat.herokuapp.com/posts';
    dateTimeUrl = 'http://date.jsontest.com/';
    //myServerUrl = 'http://localhost:3000/students'; // This is the URL for task #3

    yourIp = httpRequest.getJson(ipUrl, dataType);

    $.when(yourIp.done(function () {
        console.log(yourIp.responseJSON);
    }));

    $.when(yourIp.fail(function () {
        throw new Error('Query could not be completed. Error #' + yourIp.status)
    }));

    dateTime = httpRequest.postJson(dateTimeUrl, dataType);

    $.when(dateTime.done(function () {
        console.log(dateTime.responseJSON);
    }));

    $.when(dateTime.fail(function () {
        throw new Error('Query could not be completed. Error #' + dateTime.status)
    }));

    // Uncomment to test the server in task 3.
    // In order to test, you have to run it first...
    //var studentsArray = httpRequest.getJson(myServerUrl, dataType);

    //$.when(studentsArray.done(function () {
    //    console.log(studentsArray.responseJSON);
    //}));

    //var student = { name: 'Test Student', grade: 10 };
    //var addStudent = httpRequest.postJson(myServerUrl, dataType, student);

    //$.when(addStudent.done(function () {
    //    console.log(addStudent.responseJSON);
    //}));
}());