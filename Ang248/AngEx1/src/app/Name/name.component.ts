import { Component, OnInit } from '@angular/core';
import { NameService } from '../name.service';

@Component({
  selector: 'app-name',
  templateUrl: './name.component.html',
  styleUrls: ['./name.component.css']
})
export class NameComponent implements OnInit {

  constructor(private service : NameService) { }

  FirstName : string = "";
  LastName : string ="";

  ngOnInit(): void {
    this.FirstName = this.service.Fn();
    this.LastName = this.service.Ln();
  }

}
