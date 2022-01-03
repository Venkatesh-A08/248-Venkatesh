class Car {
    constructor(brand) {
      this.carname = brand;
    }
    present() {
      console.log( 'I have a ' + this.carname);
    }
  }
  
  class Model extends Car {
    constructor(brand, mod) {
      super(brand);
      this.model = mod;
    }
    show() {
      console.log( ', it is a ' + this.model);
    }
  }
  
  let myCar = new Model("Ford", "Mustang");
  myCar.present();
  myCar.show();