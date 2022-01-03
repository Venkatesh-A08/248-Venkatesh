const readline = require("readline-sync");
var n = String(readline.question("\nEnter a Name : "));
var rev = ""
for (var i = n.length-1; i >= 0; i--){
    rev = rev+n[i]
}
if (rev == n){
    console.log("This is Palindrome")
}else{
    console.log("This is not Palindrome")
}