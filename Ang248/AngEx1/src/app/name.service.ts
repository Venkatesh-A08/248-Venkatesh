import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class NameService {

  constructor() { }

  Fn() : string {
    let firstName = "Deepak";
    return firstName
  }
  
  Ln() : string {
    let lastName = "Venkat";
    return lastName
  }
}
