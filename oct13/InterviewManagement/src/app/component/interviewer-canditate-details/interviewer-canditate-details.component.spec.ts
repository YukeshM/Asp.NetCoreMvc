import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InterviewerCanditateDetailsComponent } from './interviewer-canditate-details.component';

describe('InterviewerCanditateDetailsComponent', () => {
  let component: InterviewerCanditateDetailsComponent;
  let fixture: ComponentFixture<InterviewerCanditateDetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InterviewerCanditateDetailsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InterviewerCanditateDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
