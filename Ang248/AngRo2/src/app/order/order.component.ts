import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.css']
})
export class OrderComponent implements OnInit {

  id: any;
  observerId: string | undefined|null;
  constructor(private route : ActivatedRoute) { }

  ngOnInit(): void {
    this.id = this.route.snapshot.params['id']

    this.route.paramMap.subscribe(params =>{
      this.observerId = params.get('id') 
    })
  }

}
