import { Component, OnInit } from '@angular/core';
import { GetCandidateRound } from 'src/app/CustomModel/get-candidate-round';
import { HumanResourceService } from 'src/app/service/human-resource.service';

@Component({
  selector: 'app-candidate-round-information',
  templateUrl: './candidate-round-information.component.html',
  styleUrls: ['./candidate-round-information.component.css']
})
export class CandidateRoundInformationComponent implements OnInit {

  public candidateDetails : GetCandidateRound[] = [];


  constructor(private _HumanResourceService : HumanResourceService) { }

  ngOnInit() {
    this._HumanResourceService.GetAllCandidate()
      .subscribe(data => this.candidateDetails = data);

  }
  GetCandidateInfoById(id : any){}


}
