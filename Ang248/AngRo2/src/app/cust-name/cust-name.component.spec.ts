import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CustNameComponent } from './cust-name.component';

describe('CustNameComponent', () => {
  let component: CustNameComponent;
  let fixture: ComponentFixture<CustNameComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CustNameComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CustNameComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
