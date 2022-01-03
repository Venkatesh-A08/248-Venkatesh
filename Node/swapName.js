const readline = require("readline-sync");
var n = String(readline.question("\nEnter a Name : "));
var r = ""
var v = ""
for (var i=0; i<n.length; i++){
    if (n[i] == " "){
        for(var j=i+1; j<n.length; j++){
            r = r+n[j]
        }
        for (var x=0; x<=i; x++){
            v = v+n[x]
        }
    }
    continue
}
console.log(r+" "+v)