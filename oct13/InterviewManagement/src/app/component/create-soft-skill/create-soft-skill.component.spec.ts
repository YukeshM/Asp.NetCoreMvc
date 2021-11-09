import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateSoftSkillComponent } from './create-soft-skill.component';

describe('CreateSoftSkillComponent', () => {
  let component: CreateSoftSkillComponent;
  let fixture: ComponentFixture<CreateSoftSkillComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateSoftSkillComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateSoftSkillComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
