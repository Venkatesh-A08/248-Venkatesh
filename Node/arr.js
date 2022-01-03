const readline = require("readline-sync");
var Bike = ["Yamaha","Honda", "Hero"]

console.log(Bike)

while(true){
console.log("\n1.Add\n 2.Delete\n 3.Display\n 4.Replace \nCTR-C to Exit")
var x = Number(readline.question("\nEnter a choice : "));

switch (x) {
    case 1:
        var y = String(readline.question("\nAdd Element : "));
        Bike.push(y)
        console.log("\nAdded")
        break;
    case 2:
        Bike.pop()
        console.log("\nRemoved")
        break;
    case 3:
        console.log(Bike)
        break;
    case 4:
        var v = Number(readline.question("\nEnter a element position : "));
        Bike.pop(v-1)
        var a = String(readline.question("\nEnter a value : "));
        Bike[v] = a
        console.log("\nReplaced")
        break;
    default:
        break
}
}