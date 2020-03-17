import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PendingIdeasComponent } from './pending-ideas.component';

describe('PendingIdeasComponent', () => {
  let component: PendingIdeasComponent;
  let fixture: ComponentFixture<PendingIdeasComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PendingIdeasComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PendingIdeasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
