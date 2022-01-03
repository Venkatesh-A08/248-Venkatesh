const readline = require("readline-sync");
var n = String(readline.question("\nEnter a String : "));
var rev = ""
for (var i = n.length-1; i >= 0; i--){
    rev = rev+n[i]
}
console.log(rev)