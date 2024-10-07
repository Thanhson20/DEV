$(document).ready(function(){
    $("#HTML").click(function(){
        $("#HTML").css("background-color","red")
        $("#content").text("Html viết tắt HyperText Marup Language");
        $("#PHP,#CSS,#Jquery").css("background-color", "#ccc");
    })
    $("#CSS").click(function(){
        $("#CSS").css("background-color","blue")
        $("#content").text("Html viết tắt HyperText Marup Language");
        $("#PHP,#HTML,#Jquary").css("backgroud-color", "#ccc");
    })
    $("#Jquery").click(function(){
        $("#Jquery").css("background-color","violet")
        $("#content").text("Html viết tắt HyperText Marup Language");
        $("#PHP,#CSS,#HTML").css("backgroud-color", "#ccc");
    })
    $("#PHP").click(function(){
        $("#PHP").css("background-color","green")
        $("#content").text("Html viết tắt HyperText Marup Language");
        $("#HTML,#CSS,#Jquary").css("backgroud-color", "#ccc");
    })
})