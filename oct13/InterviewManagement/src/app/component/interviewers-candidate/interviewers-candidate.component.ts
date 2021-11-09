import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { GetCandidateRound } from 'src/app/CustomModel/get-candidate-round';
import { InterviewerService } from 'src/app/service/interviewer.service';

@Component({
  selector: 'app-interviewers-candidate',
  templateUrl: './interviewers-candidate.component.html',
  styleUrls: ['./interviewers-candidate.component.css']
})
export class InterviewersCandidateComponent implements OnInit {

  public candidateDetails : GetCandidateRound[] = [];
  
  constructor(private _interviewerService : InterviewerService) { }

  ngOnInit() {
    return this._interviewerService.GetAllCandidate()
    .subscribe( data => this.candidateDetails = data);
  }


  GetCandidateInfoById(id : any){

  }
}
