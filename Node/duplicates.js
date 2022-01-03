const n = [1,1,2,3,4,6,7,8,9,6,5,3,2,1]
var s = []
for(let i =0; i < n.length; i++){
    if (!s.includes(n[i])){
        s.push(n[i])
    }
}
console.log(s)