import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CalcService {

  constructor() { }

  Add(): string{
    let a = 10;
    let b = 10;
    let c = a+b;
    return c.toString()
  }
  sub(): string{
    let a = 10;
    let b = 10;
    let c = a-b;
    return c.toString()
  }
}
