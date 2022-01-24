import { Component, OnInit } from '@angular/core';
import { DatetimeService } from '../datetime.service';

@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.css']
})
export class OrderComponent implements OnInit {

  constructor(private service : DatetimeService) { }

  currentDate : string = "";

  ngOnInit(): void {
    this.currentDate = this.service.currentdate();
  }

}
