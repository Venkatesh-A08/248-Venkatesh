import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'AngApiEx';
 

  constructor(private http : HttpClient ){

  }
  ngOnInit() : void{
    this.http.get('https://github.com/bbachi/angular-nodejs-example.git').subscribe(data => {
      console.log(data)
    })
  }
}
