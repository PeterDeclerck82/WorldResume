$(document).ready(function () {         // .ready = deze function word enkel opgeroepen als de volledige
                                        // pagina is geladen

    var x = 0;
    var s = "";


    var theForm = $("#theForm");        // = document.getElementById("theForm");
    // " $ " staat voor het gebruik van jQuery
    theForm.hide();


    var button = $("#addButton");       // = document.getElementById("addButton");
    button.on("click", function () {    // = button.addEventListener("click", function () {
        console.log("Adding item");
    });



    var productInfo = $(".product-props li");      //document.getElementByClassName("product-props");
    productInfo.on("click", function () {
        console.log("You clicked on " + $(this).text());
    });



    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", function () {
        $popupForm.fadeToggle(500);                //als het zichtbaar is, uit; en omgekeerd
    });


});