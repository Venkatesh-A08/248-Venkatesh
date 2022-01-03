const readline = require("readline-sync");
var n = String(readline.question("\nEnter a Number : "));
var c = ""
var num = ""
for (var i = 0; i<3; i++){
    c = c + n[i]
}
for ( i =3; i<n.length; i++){
    num = num + n[i]
}
console.log(c+" "+num)