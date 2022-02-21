import { ComponentFixture, TestBed } from '@angular/core/testing';
import { HttpClient } from "@angular/common/http";

import { ProductComponent } from './product.component';

describe('ProductComponent', () => {
  let component: ProductComponent;
  let fixture: ComponentFixture<ProductComponent>;
  let h2: HTMLElement;
  let http: HttpClient

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProductComponent ]
      
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
    h2 = fixture.nativeElement.querySelector('h2');
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
  it('should display heading',() => {
    expect(h2).toContain('Add Product')
  })
});
