import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CandidateInfoComponent } from './component/candidate-info/candidate-info.component';
import { CandidateRoundInformationComponent } from './component/candidate-round-information/candidate-round-information.component';
import { GetCandidateComponent } from './component/get-candidate/get-candidate.component';
import { InterviewerCanditateDetailsComponent } from './component/interviewer-canditate-details/interviewer-canditate-details.component';
import { InterviewerFeedbackComponent } from './component/interviewer-feedback/interviewer-feedback.component';
import { InterviewersCandidateComponent } from './component/interviewers-candidate/interviewers-candidate.component';
import { UpdateCandidateComponent } from './component/update-candidate/update-candidate.component';


const routes: Routes = [
  {
    path: 'CandidateInformation',
    component: CandidateInfoComponent},
  {
    path: 'CandidateRoundInformation',
    component: CandidateRoundInformationComponent
  },
  {
    path: 'CandidateInterviewInformation',
    component: InterviewerCanditateDetailsComponent
  },
  {
    path: 'InterviewerFeedback',
    component: InterviewerFeedbackComponent
  },
  {
    path: 'CandidateRoundInformationById',
    component: GetCandidateComponent
  },
  {
    path : 'InterviewerCandidateDetails',
    component : InterviewersCandidateComponent
  },
  {
    path: 'UpdateCandidate',
    component: UpdateCandidateComponent
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const routingComponents = [CandidateInfoComponent, CandidateRoundInformationComponent, InterviewerCanditateDetailsComponent,
InterviewerFeedbackComponent]