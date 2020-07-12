var x = 0;
var s = "";

var theForm = document.getElementById("theForm");

theForm.hidden = false;

var button = document.getElementById("addButton");
button.addEventListener("click", function () {
    console.log("Adding item");
});

var productInfo = document.getElementByClassName("product-props");
var listItems = productInfo.item[0].children