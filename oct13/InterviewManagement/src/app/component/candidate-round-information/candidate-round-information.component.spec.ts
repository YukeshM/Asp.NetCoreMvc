import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CandidateRoundInformationComponent } from './candidate-round-information.component';

describe('CandidateRoundInformationComponent', () => {
  let component: CandidateRoundInformationComponent;
  let fixture: ComponentFixture<CandidateRoundInformationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CandidateRoundInformationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CandidateRoundInformationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
