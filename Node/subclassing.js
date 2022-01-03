class Animal {
    constructor(name) {
        this.name = name;
    }
    speak() {
        console.log(`${this.name} make a noise`)
    }
}
  class Food extends Animal {
    constructor(name,meet) {
        super(name)
        this.meet = meet
    }
    Meet() {
        console.log(`${this.meet} eaten Meet`);
    }
}
 var animal = new Animal("Lion", "Meet");
 animal.speak()
 animal.Meet()