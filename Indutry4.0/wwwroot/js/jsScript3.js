//ContactAndAbout
//Add header here
const info = ["Website Author", "Email", "Telephone"];

const details = [
    //Ai
    `xxxx xxx`,

    //IOT
    `abc@xxx.com`,

    //Congnitive computing
    `+xx-xxxxxxxx`,
];

var images = ["2", "3", "4"];
var contactSection = document.getElementById("contact");
var figures = document.getElementsByTagName("figure");
var figcaption = document.getElementsByTagName("figcaption");

for (var i = 0; i < info.length; i++) {
    contactSection.innerHTML +=
        "<figure class='col-md-4 col-sm-6 col-12'>" +
        "    <img  class='tech' src='../images/Contact/" + images[i] + ".jpg '>" +
        "    <div class='overlay'>" +
        "    <figcaption class='text' >" +
    "         <h3 style='text-shadow: 2px 2px 0px navy, 2px 2px 4px white; padding-top:50px;'>" + info[i] + "</h3>" +
    "         <p>" + details[i] + "</p>" +
        "     </figcaption>" +
        "     </div>" +
        "</figure>";
}

//var contact = getElementById("contact");
contact.style.marginRight = "0px";

//figures
for (var i = 0; i < figures.length; i++) {
    figures[i].style.padding = "0px";
    figures[i].style.margin = "0px";
    figures[i].style.border = "none";
    figures[i].style.height = "100%";
    figures[i].style.width = "100%";
}

//figcaption
for (var i = 0; i < figcaption.length; i++) {
    figcaption[i].style.textAlign = "center";
    figcaption[i].style.fontSize = "small";
    figcaption[i].style.width = "100%";
    figcaption[i].style.height = "100%";
    figcaption[i].style.position = "absolute";
}

//button
for (var i = 0; i < as.length; i++) {
    as[i].style.border = "1px solid white";
    as[i].style.padding = "4px";
    as[i].style.color = "white";
}


var divs = document.querySelectorAll("div");
if (divs != null) {
    for (var i = 0; i < divs.length; i++) {
        if (divs[i].className == "container") {
            divs[i].className = "container-fluid";
            divs[i].classList.add("nogap");
        }
    }
}

var p = document.querySelectorAll("p");
if (p != null) {
    for (var i = 0; i < p.length; i++) {
        p[i].classList.add("pContact");
    }
}
