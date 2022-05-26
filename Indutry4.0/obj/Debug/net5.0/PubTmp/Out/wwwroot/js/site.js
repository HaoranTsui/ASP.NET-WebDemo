// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//$(document).ready(function () {
//    $(function () {
//        $("#elasticGrid").elastic_grid({
//            'showAllText': 'All',
//            'filterEffect': 'popup',
//            'hoverDirection': true,
//            'hoverDelay': 0,
//            'hoverInverse': false,
//            'expandingSpeed': 500,
//            'expandingHeight': 450,
//            'items':
//                [
//                    {
//                        'title': 'IBM AI <hr/> <a class="btn btn-primary">More Details</a>',
//                        'thumbnail': ['/images/Icon/sIcon/ibm.jpg'],
//                        'large': ['/images/Icon/ibm.jpg'],
//                        'button_list':
//                            [
//                                { 'title': 'Visit Website', 'url': 'https://www.ibm.com/watson/', 'new_window': true },
//                            ],
//                    },

//                    {
//                        'title': 'IBM AI <hr/> <a class="btn btn-primary">More Details</a>',
//                        'thumbnail': ['/images/Icon/sIcon/ibm.jpg'],
//                        'large': ['/images/Icon/ibm.jpg'],
//                        'button_list':
//                            [
//                                { 'title': 'Visit Website', 'url': 'https://www.ibm.com/watson/', 'new_window': true },
//                            ],
//                    },

//                    {
//                        'title': 'IBM AI <hr/> <a class="btn btn-primary">More Details</a>',
//                        'thumbnail': ['/images/Icon/sIcon/ibm.jpg'],
//                        'large': ['/images/Icon/ibm.jpg'],
//                        'button_list':
//                            [
//                                { 'title': 'Visit Website', 'url': 'https://www.ibm.com/watson/', 'new_window': true },
//                            ],
//                    },
//                ]
//        });
//    });

//    $(function () {
//        $("#grid2").elastic_grid({
//            'showAllText': 'All',
//            'filterEffect': 'popup',
//            'hoverDirection': true,
//            'hoverDelay': 0,
//            'hoverInverse': false,
//            'expandingSpeed': 500,
//            'expandingHeight': 450,
//            'items':
//                [
//                    {
//                        'title': 'IBM AI <hr/> <a class="btn btn-primary">More Details</a>',
//                        'thumbnail': ['/images/Icon/sIcon/ibm.jpg'],
//                        'large': ['/images/Icon/ibm.jpg'],
//                        'button_list':
//                            [
//                                { 'title': 'Visit Website', 'url': 'https://www.ibm.com/watson/', 'new_window': true },
//                            ],
//                    },

//                    {
//                        'title': 'IBM AI <hr/> <a class="btn btn-primary">More Details</a>',
//                        'thumbnail': ['/images/Icon/sIcon/ibm.jpg'],
//                        'large': ['/images/Icon/ibm.jpg'],
//                        'button_list':
//                            [
//                                { 'title': 'Visit Website', 'url': 'https://www.ibm.com/watson/', 'new_window': true },
//                            ],
//                    },

//                    {
//                        'title': 'IBM AI <hr/> <a class="btn btn-primary">More Details</a>',
//                        'thumbnail': ['/images/Icon/sIcon/ibm.jpg'],
//                        'large': ['/images/Icon/ibm.jpg'],
//                        'button_list':
//                            [
//                                { 'title': 'Visit Website', 'url': 'https://www.ibm.com/watson/', 'new_window': true },
//                            ],
//                    },
//                ]
//        });
//    });

//});

var divs = document.querySelectorAll("div");
if (divs != null) {
    for (var i = 0; i < divs.length; i++) {
        if (divs[i].className == "container") {
            divs[i].className = "container-fluid";
            divs[i].classList.add("nogap");
        }
    }
}

//For collapsible
var coll = document.getElementsByClassName("collapsible");
var i;

for (i = 0; i < coll.length; i++) {
    coll[i].addEventListener("click", function () {
        this.classList.toggle("active");
        var content = this.nextElementSibling;
        if (content.style.display === "block") {
            content.style.display = "none";
        } else {
            content.style.display = "block";
        }
    });
}