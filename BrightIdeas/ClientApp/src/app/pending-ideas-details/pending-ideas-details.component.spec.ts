import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PendingIdeasDetailsComponent } from './pending-ideas-details.component';

describe('PendingIdeasDetailsComponent', () => {
  let component: PendingIdeasDetailsComponent;
  let fixture: ComponentFixture<PendingIdeasDetailsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PendingIdeasDetailsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PendingIdeasDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
