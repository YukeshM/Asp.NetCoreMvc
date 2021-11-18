import { Component, OnInit } from '@angular/core';
import { GetCandidateStatus } from 'src/app/CustomModel/get-candidate-status';
import { GetInterviewer } from 'src/app/CustomModel/get-interviewer';
import { GetRound } from 'src/app/CustomModel/get-round';
import { HumanResourceService } from 'src/app/service/human-resource.service';

@Component({
  selector: 'app-interviewer-canditate-details',
  templateUrl: './interviewer-canditate-details.component.html',
  styleUrls: ['./interviewer-canditate-details.component.css']
})
export class InterviewerCanditateDetailsComponent implements OnInit {

  public round : GetRound[] = [];

  public status : GetCandidateStatus[] = [];

  public interviewer : GetInterviewer[] = [];

  constructor(private _humanResourceService : HumanResourceService) { }

  ngOnInit(): void {
    this._humanResourceService.GetRound().subscribe(
      data => this.round = data
      );

    this._humanResourceService.GetCandidateStatus().subscribe(
      data => this.status = data
    );

    this._humanResourceService.GetInterviewer().subscribe(
      data => this.interviewer = data
    );
    
  }

}
