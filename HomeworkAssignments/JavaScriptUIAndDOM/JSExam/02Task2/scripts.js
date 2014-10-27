/// <reference path="jquery.min.js" />

$.fn.gallery = function (count) {

    var $this = $(this);
    $('#root').addClass('gallery');
    $('.selected').hide();

    switch (count) {
        case 3: $('#root').css('width', '780px'); break;
        case 5: $('#root').css('width', '100%'); break;
        default: $('#root').css('width', '1040px'); break;
    }

    $('.image-container img').on('click', function () {
        console.log($(this).parent());
        if ($('.gallery-list').hasClass('blurred')) {
            return false;
        }

        $('.gallery-list').addClass('blurred');

        var $this = $(this);
        var curLink = $this.attr('data-info');
        var preLink = '';
        var nextLink = '';

        if ((parseInt(curLink) - 1) === 0) {
            preLink = '12';
        } else {
            preLink = (parseInt(curLink) - 1);
        }
        if ((parseInt(curLink) + 1) === 13) {
            nextLink = '1';
        } else {
            nextLink = (parseInt(curLink) + 1);
        }

        $('.selected #previous-image').attr('src', 'imgs/' + preLink + '.jpg');
        $('.selected #previous-image').attr('data-info', '' + preLink);

        $('.selected #current-image').attr('src', 'imgs/' + curLink + '.jpg');
        $('.selected #current-image').attr('data-info', '' + curLink);

        $('.selected #next-image').attr('src', 'imgs/' + nextLink + '.jpg');
        $('.selected #next-image').attr('data-info', '' + nextLink);

        $('.selected').show();
    });

    $('.selected #current-image').on('click', function () {
        $('.selected').hide();
        $('.gallery-list').removeClass('blurred');
    });

    $('.selected #previous-image').on('click', function () {
        var $this = $(this);
        var x = $this.attr('data-info');
        var pre = '';

        if ((parseInt(x) - 1) === 0) {
            pre = '12';
        } else {
            pre = (parseInt(x) - 1);
        }

        var cur = $('#previous-image').attr('data-info');
        var nex = $('#current-image').attr('data-info');

        $('.selected #previous-image').attr('src', 'imgs/' + pre + '.jpg');
        $('.selected #previous-image').attr('data-info', '' + pre);

        $('.selected #current-image').attr('src', 'imgs/' + cur + '.jpg');
        $('.selected #current-image').attr('data-info', '' + cur);

        $('.selected #next-image').attr('src', 'imgs/' + nex + '.jpg');
        $('.selected #next-image').attr('data-info', '' + nex);
    });

    $('.selected #next-image').on('click', function () {
        var $this = $(this);
        var x = $this.attr('data-info');
        var next = '';
        if ((parseInt(x) + 1) === 13) {
            next = '1';
        } else {
            next = (parseInt(x) + 1);
        }

        var cur = $('#next-image').attr('data-info');
        var pre = $('#current-image').attr('data-info');

        $('.selected #previous-image').attr('src', 'imgs/' + pre + '.jpg');
        $('.selected #previous-image').attr('data-info', '' + pre);

        $('.selected #current-image').attr('src', 'imgs/' + cur + '.jpg');
        $('.selected #current-image').attr('data-info', '' + cur);

        $('.selected #next-image').attr('src', 'imgs/' + next + '.jpg');
        $('.selected #next-image').attr('data-info', '' + next);
    });

    return $this;
};