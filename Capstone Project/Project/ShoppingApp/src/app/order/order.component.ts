import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ApiService } from '../Shared/api.service';
import { ActivatedRoute, ParamMap } from '@angular/router';


@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.css']
})
export class OrderComponent implements OnInit {

  orderDetails: any = [];
  viewOderDetails: any;
  routeId: any;

  constructor(private formbuilder: FormBuilder, private api: ApiService, private routed: ActivatedRoute) { }


  ngOnInit(): void {
    this.routed.paramMap.subscribe((params: ParamMap) => {
      this.routeId = params.get('id');
    })
    this.getOder();
  }
  getOder() {
    this.api.getOrder().subscribe((resp: any) => {
      this.orderDetails = resp
        .filter((item: any) => {
          return item.loginId== this.routeId
        });
      console.log(resp)
    })
  }
  deletFun(OrderNumber: any) {
    console.log(OrderNumber);
    this.api.deleteOrder(OrderNumber).subscribe((resp: any) => {
      this.getOder()
    })
  }
  viewFun(item: any) {
    console.log(item);
    this.viewOderDetails = item;

  }


}


