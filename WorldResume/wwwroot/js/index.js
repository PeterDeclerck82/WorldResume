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
})