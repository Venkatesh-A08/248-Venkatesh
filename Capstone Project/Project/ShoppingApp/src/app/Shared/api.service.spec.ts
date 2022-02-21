import { TestBed } from '@angular/core/testing';
import { HttpClient } from "@angular/common/http";
import { HttpClientTestingModule,HttpTestingController } from "@angular/common/http/testing";

import { ApiService } from './api.service';

describe('ApiService', () => {
  let service: ApiService;
  let http: HttpClient;
  let httpController: HttpTestingController;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports:[HttpClientTestingModule],
      providers:[ApiService]
    });
    service = TestBed.inject(ApiService);
    TestBed.inject(HttpClient);
    httpController = TestBed.inject(HttpTestingController);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
