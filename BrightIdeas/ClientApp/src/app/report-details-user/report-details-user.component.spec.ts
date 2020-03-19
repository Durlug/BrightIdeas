import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ReportDetailsUserComponent } from './report-details-user.component';

describe('ReportDetailsUserComponent', () => {
  let component: ReportDetailsUserComponent;
  let fixture: ComponentFixture<ReportDetailsUserComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ReportDetailsUserComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ReportDetailsUserComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
