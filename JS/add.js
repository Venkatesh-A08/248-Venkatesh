function add(){
var fn = parseInt(document.getElementById("fn").value);
var sn = parseInt(document.getElementById("sn").value);
document.getElementById("result").innerHTML = "Answer is : "+ (fn+sn);
function sub(){
    var fn = parseInt(document.getElementById("fn").value);
    var sn = parseInt(document.getElementById("sn").value);
    document.getElementById("result").innerHTML = "Answer is : "+ (fn-sn);
}
function mul(){
    var fn = parseInt(document.getElementById("fn").value);
    var sn = parseInt(document.getElementById("sn").value);
    document.getElementById("result").innerHTML = "Answer is : "+ (fn*sn);
}
 function div(){
    var fn = parseInt(document.getElementById("fn").value);
    var sn = parseInt(document.getElementById("sn").value);
    document.getElementById("result").innerHTML = "Answer is : "+ (fn/sn);
}
}