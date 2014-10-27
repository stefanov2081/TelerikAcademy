/// <reference path="jquery-2.1.1.js" />

(function ($) {
	"use strict";

	var $this, $valueArray = [], $div, $ul, i;

	$.fn.dropdown = function () {
		$this = $(this);
		$this.attr('style', 'display: none');
		$div = $('<div>');
		$ul = $('<ul>');
		$div.addClass('dropdown-list-container');
		$ul.addClass('dropdown-list-options');

		$div.css({
			display: 'inline-block',
			border: '1px solid #000',
			background: '#ccc',
			cursor: 'default'
		});


		$ul.css({
			display: 'none',
			margin: 0,
			padding: 0,
		});
		$ul.css('list-style-type', 'none');

		for (i = 0; i < $this[0].length; i += 1) {
			$ul.append('<li class="dropdown-list-option" data-value="' + i + '">' + $this[0][i].text + '</li>')
		}

		$div.append('<p>&#x25BC ' + $this[0][0].text);
		$div.children('p').css({
			padding: '0 10px',
		});

		$div.append($ul);
		$this.after($div);

		$div.on('click', function () {
			if ($ul.css('display') === 'none') {
				$ul.fadeIn(1000).css('display', 'block');
			} else if ($ul.css('display') === 'block') {
				$ul.css('display', 'none');
			}
		});

		$ul.children('li').on('mouseenter', function () {
			$(this).css({
				background: '#00F',
				bordertop: '1px solid #000',
				borderbottom: '1px solid #000'
			})

		});

		$ul.children('li').on('mouseleave', function () {
			$(this).css({
				background: '#CCC',
				bordertop: 'none',
				borderbottom: 'none'
			})

		});

		$ul.children('li').on('click', function () {
			$('p').remove('p', false);
			//$div.children(':first-child').before().append('<p>&#x25BC ' + $(this).text());
			$div.prepend('<p>&#x25BC ' + $(this).text() + '</p>');
			$div.children('p').css({
				padding: '0 10px',
			});

			console.log($(this));
		});
	};
}(jQuery));