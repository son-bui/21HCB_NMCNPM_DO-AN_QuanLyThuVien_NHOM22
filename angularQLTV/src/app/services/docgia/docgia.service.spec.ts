import { TestBed } from '@angular/core/testing';

import { DocgiaService } from './docgia.service';

describe('DocgiaService', () => {
  let service: DocgiaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DocgiaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
