import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { QAManagementComponent } from './q-aManagement.component';

describe('QAManagementComponent', () => {
  let component: QAManagementComponent;
  let fixture: ComponentFixture<QAManagementComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ QAManagementComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(QAManagementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
