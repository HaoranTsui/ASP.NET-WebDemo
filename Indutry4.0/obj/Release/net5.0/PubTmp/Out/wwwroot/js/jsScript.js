//js script for homepage
const title = ["Artificial intelligence",
                "The internet of things",
                "Cognitive computing",
                "Cloud computing",
                "Robotics",
                "Blockchain"];

var images = ["ai", "iot", "cognitive", "cloud", "robotics", "blockchain"];

var links = ["Home/EmergingTechnologies/#headingOne", "Home/EmergingTechnologies/#headingTwo",
    "Home/EmergingTechnologies/#headingThree", "Home/EmergingTechnologies/#headingFour",
    "Home/EmergingTechnologies/#headingFive", "Home/EmergingTechnologies/#headingSix"];


const contents = [
  `Artificial intelligence (AI) is intelligence demonstrated by machines, as opposed to the natural intelligence displayed by humans or animals. 
  Leading AI textbooks define the field as the study of "intelligent agents": any system that perceives its environment and takes actions that maximize 
  its chance of achieving its goals (Wikipedia).`, 

  `The Internet of things (IoT) describes the network of physical objects, so known as, "things" — that are embedded with sensors, software, and other technologies 
  that is used for the purpose of connecting and exchanging data with other devices and 
  systems over the Internet (Wikipedia).`,

  `Cognitive computing (CC) refers to technology platforms that, broadly speaking, are based on 
  the scientific disciplines of artificial intelligence and signal processing. These platforms encompass machine 
  earning, reasoning, natural language processing, speech recognition and vision (object recognition), 
  human–computer interaction, dialog and narrative generation, among other technologies (Wikipedia).`,

  `Cloud computing is the on-demand availability of computer system resources, especially data storage 
  (cloud storage) and computing power, without direct active management by the user. Large clouds often have functions 
  distributed over multiple locations, each location being a data center (Wikipedia).`,

  ` Robotics is an interdisciplinary field that integrates computer science and engineering. Robotics involves design, construction, operation, and use of robots.
The goal of robotics is to design machines that can help and assist humans (Wikipedia).`,

  ` A blockchain is a growing list of records, called blocks, that are linked together using cryptography. 
  Each block contains a cryptographic hash of the previous block, a timestamp, and transaction data (generally represented 
  as a Merkle tree) (Wikipedia).`
];


var techSection = document.getElementById("tech");
var figures = document.getElementsByTagName("figure");
var figcaption = document.getElementsByTagName("figcaption");
var as = document.getElementsByClassName("btn-default");
var text = document.getElementsByClassName("text");

for (var i = 0; i < title.length; i++){
  techSection.innerHTML +=
      "<figure class='col-md-4 col-sm-6 col-12'>" + 
      "    <img  class='tech' src='images/Homepage/" + images[i] + ".jpg '>" +
      "    <div class='overlay'>" +
      "    <figcaption class='text' >"+
  "         <h3 style='text-shadow: 2px 2px 0px navy, 2px 2px 4px white;'>" + title[i] + "</h3>" +
      "         <p>" + contents[i] + "</p>" +
      "     <a href='" +links[i]+"' class='btn btn-default'>Read more</a>" +
      "     </figcaption>" +
      "     </div>"+
      "</figure>";
}

//figures
for (var i = 0; i < figures.length; i++){
  figures[i].style.padding = "0px";
  figures[i].style.margin = "0px";
  figures[i].style.border = "none";
  figures[i].style.height= "100%";
  figures[i].style.width = "100%";
    figures[i].style.backgroundSize = "cover";
    figures[i].style.backgroundPosition = ""
}

//figcaption
for (var i = 0; i < figcaption.length; i++){
  figcaption[i].style.textAlign = "center";
  figcaption[i].style.fontSize = "small";
  figcaption[i].style.width = "100%";
  figcaption[i].style.height = "100%";
  figcaption[i].style.position = "absolute";
}

//button
for (var i = 0; i < as.length; i++){
  as[i].style.border = "1px solid white";
  as[i].style.padding = "4px";
  as[i].style.color = "white";
}

techSection.style.marginRight = "0px";
techSection.style.marginLeft = "0px";


var divs = document.querySelectorAll("div");
if (divs != null) {
    for (var i = 0; i < divs.length; i++) {
        if (divs[i].className == "container") {
            divs[i].className = "container-fluid";
            divs[i].classList.add("nogap");
        }
    }
}

var sTitle = document.getElementsByClassName("stitle");
