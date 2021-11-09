import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateTechnicalSkillComponent } from './create-technical-skill.component';

describe('CreateTechnicalSkillComponent', () => {
  let component: CreateTechnicalSkillComponent;
  let fixture: ComponentFixture<CreateTechnicalSkillComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateTechnicalSkillComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateTechnicalSkillComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
