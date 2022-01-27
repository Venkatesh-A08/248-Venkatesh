import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-birthday',
  templateUrl: './birthday.component.html',
  styleUrls: ['./birthday.component.css']
})
export class BirthdayComponent implements OnInit {

  constructor() { }

  title = "Pipe"
  TodayDate = new Date();
  

  ngOnInit(): void {
  }

}
