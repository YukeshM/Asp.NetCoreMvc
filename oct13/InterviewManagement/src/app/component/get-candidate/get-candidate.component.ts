import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
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

  constructor(private _humanResourceService : HumanResourceService,
              private _router : Router) { }

  ngOnInit() {
    console.warn(this._humanResourceService.id);
    this._humanResourceService.GetCandidateById(this._humanResourceService.id)
    .subscribe( data => this.candidateInfoById = data);
  }

  gotopage(link : string){
    this._router.navigateByUrl(link);
  }
  

}
