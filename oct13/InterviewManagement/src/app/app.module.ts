import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule, routingComponents } from './app-routing.module';
import { AppComponent } from './app.component';

import { CandidateInfoComponent } from './component/candidate-info/candidate-info.component';

import { CandidateRoundInformationComponent } from './component/candidate-round-information/candidate-round-information.component';
import { InterviewerCanditateDetailsComponent } from './component/interviewer-canditate-details/interviewer-canditate-details.component';
import { NavbarComponent } from './component/navbar/navbar.component';
import { HeaderComponent } from './component/header/header.component';
import { InterviewerFeedbackComponent } from './component/interviewer-feedback/interviewer-feedback.component';
import{HttpClientModule} from '@angular/common/http';
import { GetCandidateComponent } from './component/get-candidate/get-candidate.component'
import { ReactiveFormsModule } from '@angular/forms';
import { InterviewersCandidateComponent } from './component/interviewers-candidate/interviewers-candidate.component';
import { CreateSoftSkillComponent } from './component/create-soft-skill/create-soft-skill.component';
import { CreateTechnicalSkillComponent } from './component/create-technical-skill/create-technical-skill.component';


@NgModule({
  declarations: [
    AppComponent,
    CandidateInfoComponent,
    CandidateRoundInformationComponent,
    routingComponents,
    InterviewerCanditateDetailsComponent,
    NavbarComponent,
    HeaderComponent,
    InterviewerFeedbackComponent,
    GetCandidateComponent,
    InterviewersCandidateComponent,
    CreateSoftSkillComponent,
    CreateTechnicalSkillComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
