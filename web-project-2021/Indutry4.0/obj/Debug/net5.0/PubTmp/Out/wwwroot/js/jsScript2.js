//companies images

var companiesHeadings = ["IBM", "Amazon", "Google", "Microsoft", "CSIRO", "Department of Industry, Science, Energy and Resources"];
var companiesImg = ["ibm", "amazon", "google", "microsoft", "csiro", "department"];

var links = ['https://www.ibm.com/us-en/', 'https://aws.amazon.com/manufacturing/',
    'https://ai.google/', 'https://www.microsoft.com/en-us/ai?activetab=pivot1%3aprimaryr6',
    'https://www.csiro.au/', 'https://www.industry.gov.au/'];

var companiesSection = document.getElementById("companies");
var companiesfFigures = document.getElementsByTagName("figure");
var companiesFigcaption = document.getElementsByTagName("figcaption");
var btn = document.getElementsByClassName("btn-info");
var text = document.getElementsByClassName("text");

 for (var i = 0; i < companiesHeadings.length; i++) {
     companiesSection.innerHTML +=
         "<figure class='col-md-4 col-sm-6 col-12'>" +
         "    <img  class='tech' src='../images/Companies/" + companiesImg[i] + ".jpg '>" +
         "    <div class='overlay'>" +
         "    <figcaption class='text' >" +
         "<h3 >" + companiesHeadings[i] + "</h3>" +
         "<a  href=" + links[i] + " type='button' class='btn btn-info' >View Website</a>" +
         "     </figcaption>" +
         "     </div>" +
         "</figure>";
}

companies.style.marginRight = "0px";

var figureGrid = document.getElementsByTagName("figure");
figureGrid[0].classList.add('col-md-6', 'col-sm-12', 'col-12');
figureGrid[0].style.paddingTop = "15px";
figureGrid[0].style.paddingRight = "0px";

figureGrid[1].classList.add('col-md-6', 'col-sm-12', 'col-12');
figureGrid[1].style.paddingTop = "15px";
figureGrid[1].style.paddingRight = "0px";

figureGrid[2].classList.add('col-md-12', 'col-sm-12', 'col-12');
figureGrid[2].style.paddingRight = "0px";

figureGrid[3].classList.add('col-md-6', 'col-sm-12', 'col-12');
figureGrid[3].style.paddingRight = "0px";

figureGrid[4].classList.add('col-md-6', 'col-sm-12', 'col-12');
figureGrid[4].style.paddingRight = "0px";

figureGrid[5].classList.add('col-md-12', 'col-sm-12', 'col-12');
figureGrid[5].style.paddingRight = "0px";

var h3 = document.getElementsByTagName("h3");
for (var i = 0; i < companiesHeadings.length; i++) {
    h3[i].style.fontSize = "1.75rem";
    h3[i].style.textShadow = "2px 2px 0px navy, 2px 2px 4px white";
    h3[i].style.paddingTop = "50px";
}
//button
//for (var i = 0; i < btn.length; i++) {
//    btn[i].style.border = "1px solid white";
//    btn[i].style.padding = "4px";
//    btn[i].style.color = "blue";
//}


var divs = document.querySelectorAll("div");
if (divs != null) {
    for (var i = 0; i < divs.length; i++) {
        if (divs[i].className == "container")
        {
            divs[i].className = "container-fluid";
            divs[i].classList.add("nogap");
        }
    }
}





