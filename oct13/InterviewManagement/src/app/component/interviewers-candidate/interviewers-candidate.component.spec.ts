import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InterviewersCandidateComponent } from './interviewers-candidate.component';

describe('InterviewersCandidateComponent', () => {
  let component: InterviewersCandidateComponent;
  let fixture: ComponentFixture<InterviewersCandidateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InterviewersCandidateComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InterviewersCandidateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
