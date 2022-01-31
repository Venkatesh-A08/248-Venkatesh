import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'AngApi';


  constructor(private http : HttpClient){}

  ngOnInit() : void{
    this.http.get('https://api.github.com/users/abdullah').subscribe(data => {
      console.log(data);
      
    })
  } 
}
