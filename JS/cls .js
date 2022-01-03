class User {
    _name = "";
    constructor(name){
        this._name = name
    }

    sayhi(){
        console.log(this._name)
    }
}
var obj = new User("Venkatesh");
obj.sayhi();