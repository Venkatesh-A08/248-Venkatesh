import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'CompComunication';

  childData : string = ""
  catchchildEvent($event : string){
    this.childData = $event;
  }


}
