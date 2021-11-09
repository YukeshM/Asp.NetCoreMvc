import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { GetCandidateRound } from 'src/app/CustomModel/get-candidate-round';
import { HumanResourceService } from 'src/app/service/human-resource.service';

@Component({
  selector: 'app-get-candidate',
  templateUrl: './get-candidate.component.html',
  styleUrls: ['./get-candidate.component.css']
})
export class GetCandidateComponent implements OnInit {

  public candidateInfoById : GetCandidateRound = new GetCandidateRound();

  constructor(private _humanResourceService : HumanResourceService) { }

  ngOnInit() {
  }

  GetCandidateInfoById(id: any){
    return this._humanResourceService.GetCandidateById(id)
    .subscribe( data => this.candidateInfoById = data)
  }
  

}
