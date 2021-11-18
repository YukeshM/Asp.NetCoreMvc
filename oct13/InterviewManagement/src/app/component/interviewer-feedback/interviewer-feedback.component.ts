import { Component, OnInit } from '@angular/core';
import { GetRating } from 'src/app/CustomModel/get-rating';
import { GetRound } from 'src/app/CustomModel/get-round';
import { GetSkill } from 'src/app/CustomModel/get-skill';
import { HumanResourceService } from 'src/app/service/human-resource.service';

@Component({
  selector: 'app-interviewer-feedback',
  templateUrl: './interviewer-feedback.component.html',
  styleUrls: ['./interviewer-feedback.component.css']
})
export class InterviewerFeedbackComponent implements OnInit {

  public round : GetRound[] = [];

  public skill : GetSkill[] = [];

  public rating : GetRating[] = [];

  constructor(private _humanResourceService : HumanResourceService) { }

  ngOnInit(): void {
    this._humanResourceService.GetSkill().subscribe( data => this.skill = data);

    this._humanResourceService.GetRound().subscribe(data => this.round = data);

    this._humanResourceService.GetRating().subscribe(data => this.rating = data);
  }
}
