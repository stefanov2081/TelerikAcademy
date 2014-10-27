/// <reference path="../Libs/underscore.js" />
/*global document: false */

function print(message) {
    "use strict";

    document.getElementById('result').innerHTML += '<p>' + message + '</p>';
}

function mostPopularAuthor(collectionOfBooks) {
    "use strict"

    var mostPopularAuthor, mostPopularAuthorArray = [];

    mostPopularAuthor = _.groupBy(collectionOfBooks, 'author');
    mostPopularAuthor = _.sortBy(mostPopularAuthor, function (g) { return -g.length });
    
    return _.first(mostPopularAuthor)[0].author;
}

function main() {
    "use strict";

    var books,
       theMostPopularAuthor;

    books = [
        {
            title: 'This is very original title for a book',
            author: 'Georgi Georgiev'
        },
        {
            title: 'Very original title for a book',
            author: 'Georgi Georgiev'
        },
        {
            title: 'More original title for a book',
            author: 'Georgi Georgiev'
        },
        {
            title: 'Even more original title for a book',
            author: 'Ivan Ivanov'
        },
        {
            title: 'Very very original title for a book',
            author: 'Haralampii Lampiev'
        },
        {
            title: 'Some title',
            author: 'Ahmed Dogan'
        },
        {
            title: 'No title...',
            author: 'Ahmed Dogan'
        },
    ];

    theMostPopularAuthor = mostPopularAuthor(books);
    print(JSON.stringify(books));
    print('Most popular author is ' + theMostPopularAuthor);
}