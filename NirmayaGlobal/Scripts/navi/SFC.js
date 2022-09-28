var keptSafe0 = jQuery.noConflict();

keptSafe0('.returnUp').click(function () {
    keptSafe0('html, body').animate({
        scrollTop: keptSafe0('.baseFH').offset().top
    }, 'slow');
    return false;
});