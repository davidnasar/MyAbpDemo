import { TestBed } from '@angular/core/testing';

import { QAManagementService } from './q-aManagement.service';

describe('QAManagementService', () => {
  let service: QAManagementService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(QAManagementService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
