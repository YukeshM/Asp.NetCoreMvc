import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { CreateCandidate } from 'src/app/CustomModel/create-candidate';
import { GetSource } from 'src/app/CustomModel/get-source';
import { HumanResourceService } from 'src/app/service/human-resource.service';


@Component({
  selector: 'app-candidate-info',
  templateUrl: './candidate-info.component.html',
  styleUrls: ['./candidate-info.component.css']
})
export class CandidateInfoComponent implements OnInit {

  public source : GetSource[] = [];


  createCandidateForm : FormGroup = new FormGroup({
    ReferredBy : new FormControl(),
    Name : new FormControl(),
    LastEmployer : new FormControl(),
    LastDesignation : new FormControl(),
    NoticePeriod : new FormControl(),
    Experience : new FormControl(),
    SourceId : new FormControl(),
    MedicalStatus : new FormControl()
  });

  createCandidate : CreateCandidate = new CreateCandidate();

  constructor(private _humanResourceService : HumanResourceService) { }

  ngOnInit(): void {
    this._humanResourceService.GetSource().
    subscribe(
      data => this.source = data
    );
    // this.createCandidateForm = new FormGroup({
    // ReferredBy : new FormControl(),
    // Name : new FormControl(),
    // LastEmployer : new FormControl(),
    // LastDesignation : new FormControl(),
    // NoticePeriod : new FormControl(),
    // Experience : new FormControl(),
    // SourceId : new FormControl()
    // });
  }

  CreateCandidate() : void {
    //this.createCandidate = this.createCandidateForm.value
    this.createCandidate.ReferredBy = this.createCandidateForm.value.ReferredBy,
    this.createCandidate.Name = this.createCandidateForm.value.Name,
    this.createCandidate.LastEmployer = this.createCandidateForm.value.LastEmployer,
    this.createCandidate.LastDesignation = this.createCandidateForm.value.LastDesignation,
    this.createCandidate.Experience = this.createCandidateForm.value.Experience,
    this.createCandidate.NoticePeriod = this.createCandidateForm.value.NoticePeriod,
    this.createCandidate.SourceId = this.createCandidateForm.value.SourceId,
    this.createCandidate.MedicalStatus = this.createCandidateForm.value.MedicalStatus
    this._humanResourceService.Create(this.createCandidate).subscribe();
    //console.log(this.createCandidateForm.value);
  }
}
