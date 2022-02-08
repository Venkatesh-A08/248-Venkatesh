import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { UserResponse } from './user-response';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'AngApi';


  constructor(private http : HttpClient){}

   ngOnInit() : void{
     this.http.get('http://localhost:44361/api/Products').subscribe(data => {
      
       console.log(data)
     },
     err => {
      console.log("Error is Occur")
    }
     )
   } 

  //HttpPost

  // const  = this.http.post('http://jsonplaceholder.typicode.com/posts',
  // {
  //   title : 'foo',
  //   body : 'bar',
  //   userId : 1
  // })
  // .subscribe(res => {
  //   console.log(res)
  // },
  // err => {
  //   console.log("Error Occured")
  // })
}
