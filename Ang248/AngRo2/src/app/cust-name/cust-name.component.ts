import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-cust-name',
  templateUrl: './cust-name.component.html',
  styleUrls: ['./cust-name.component.css']
})
export class CustNameComponent implements OnInit {

  name : string | null | undefined;
  observerName : string | undefined | null;
  constructor(private route : ActivatedRoute ) { }

  ngOnInit(): void {
    this.name = this.route.snapshot.params['id'];

    this.route.paramMap.subscribe(params =>{
      this.observerName = params.get('id')
    })
  }

}
