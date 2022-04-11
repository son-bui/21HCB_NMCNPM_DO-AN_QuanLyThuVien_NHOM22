/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { NhanvienService } from './nhanvien.service';

describe('Service: Nhanvien', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [NhanvienService]
    });
  });

  it('should ...', inject([NhanvienService], (service: NhanvienService) => {
    expect(service).toBeTruthy();
  }));
});
