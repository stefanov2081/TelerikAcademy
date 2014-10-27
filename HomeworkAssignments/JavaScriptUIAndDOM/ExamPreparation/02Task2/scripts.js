$.fn.tabs = function () {
    var $this = $(this);

    $this.addClass('tabs-container');
    hideTabControlElement();

    $this.on('click', '.tab-item-title', function () {
        hideTabControlElement();
        $this.find('.tab-item').removeClass('current');
        $(this).next().show();
        $(this).parent().addClass('current');

    });

    function hideTabControlElement() {
        $this.find('.tab-item-content').hide();

    }
};