import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor() { }

  getUser(): Array<{}>{
    return[
      {
        name: "user1",
        surName:"usersurName1"
      },
      {
        name:"user2",
        surName:"usersurName2"
      }
    ];
  }
}
