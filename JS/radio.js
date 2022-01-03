function display(){
    var m = document.getElementById("Male").value;
    var f = document.getElementById("Female").value;
    var o = document.getElementById("Others").value;
    
    if (document.getElementById("Male").checked == true) {
        document.getElementById("result").innerHTML = m
    }else if (document.getElementById("Female").checked == true){
        document.getElementById("result").innerHTML = f
    }else{
        document.getElementById("result").innerHTML = o
    }
    /** another method 
     * function display(){
     * var x = doucument.getElementByName("gender");
     *  for (i=0; i < x.length; i++){
     * if (x[i].checked)
     * document.getElementById("result").innerHTML = "Gender : " + x[i].value
     * }
     * } */
}