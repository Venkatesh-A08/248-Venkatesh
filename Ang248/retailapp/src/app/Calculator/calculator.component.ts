import { Component, OnInit } from '@angular/core';
import { CalcService } from '../calc.service';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent implements OnInit {

  constructor(private service : CalcService) { }

  Add : string =""
 sub: string =""

  ngOnInit(): void {
    this.Add = this.service.Add()
    this.sub = this.service.sub()
  }

}
