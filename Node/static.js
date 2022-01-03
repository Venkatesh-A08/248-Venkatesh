class point {
    constructor(x,y){
        this.x = x;
        this.y = y;
    }
    static distance(a,b){
        this.x = a*x-b*x;
        this.y = a*y-b*y;
    }
}
var p1 = new point(5,5);
var p2 = new point(10,10);
console.log(point.distance(p1,p2))