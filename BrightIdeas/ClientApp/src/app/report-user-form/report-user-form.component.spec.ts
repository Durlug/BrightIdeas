import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ReportUserFormComponent } from './report-user-form.component';

describe('ReportUserFormComponent', () => {
  let component: ReportUserFormComponent;
  let fixture: ComponentFixture<ReportUserFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ReportUserFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ReportUserFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
