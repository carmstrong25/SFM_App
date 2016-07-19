$(document).ready(function () {
    //Slideshow
    $('.banner').revolution({
        delay: 15000,
        startwidth: 1040,
        startheight: 463,
        onHoverStop: "off",

        thumbWidth: 100,
        thumbHeight: 50,
        thumbAmount: 3,

        hideThumbs: 0,
        navigationType: "bullet",
        navigationArrows: "none",

        navigationStyle: "round-old",

        navigationHAlign: "center",
        navigationVAlign: "bottom",
        navigationHOffset: -419,
        navigationVOffset: 72,

        touchenabled: "on",

        stopAtSlide: -1,
        stopAfterLoops: -1,

        hideCaptionAtLimit: 0,
        hideAllCaptionAtLilmit: 0,
        hideSliderAtLimit: 0,

        fullWidth: "on",

        shadow: 0
    })

});