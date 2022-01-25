import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {

  constructor() { }

  @Input() parentData : string =""

  @Output() childEvent = new EventEmitter<string>()

  onChange(value : string){
    this.childEvent.emit(value);
  }

  ngOnInit(): void {
  }

}
