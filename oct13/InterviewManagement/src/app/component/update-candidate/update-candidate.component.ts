import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { GetCandidateRound } from 'src/app/CustomModel/get-candidate-round';
import { GetCandidateStatus } from 'src/app/CustomModel/get-candidate-status';
import { GetInterviewer } from 'src/app/CustomModel/get-interviewer';
import { GetRound } from 'src/app/CustomModel/get-round';
import { GetSource } from 'src/app/CustomModel/get-source';
import { UpdateCandidateRoundInformation } from 'src/app/CustomModel/update-candidate-round-information';
import { HumanResourceService } from 'src/app/service/human-resource.service';

@Component({
  selector: 'app-update-candidate',
  templateUrl: './update-candidate.component.html',
  styleUrls: ['./update-candidate.component.css']
})
export class UpdateCandidateComponent implements OnInit {

  public source: GetSource[] = [];

  public round: GetRound[] = [];

  public status: GetCandidateStatus[] = [];

  public interviewer: GetInterviewer[] = [];

  public candidateInfoById: GetCandidateRound = new GetCandidateRound();

  updateCandidateRoundInformation = new UpdateCandidateRoundInformation();

  createCandidateForm: FormGroup = this._formBuilder.group({
  });

  formErrors: any = {
    'ReferredBy': '',
    'Name': '',
    'LastEmployer': '',
    'LastDesignation': '',
    'NoticePeriod': '',
    'Experience': '',
    'SourceId': '',
    'MedicalStatus': '',
    'RoundId': '',
    'InterviewDate': '',
    'InterviewerId': '',
    'CandidateStatusId': ''
  };

  validationMessages: any = {
    'ReferredBy': {
      'minlength': 'Referred by should be greater than 2 characters',
      'required': 'Referred By is required.',
      'maxlength': 'Referred by should be not greater than 100 characters'
    },
    'Name': {
      'required': 'Name is required.',
      'minlength': 'Name should be greater than 2 characters',
      'maxlength': 'Name should be not greater than 250 characters'
    },
    'LastEmployer': {
      'required': 'Last employer is required.',
      'minlength': 'Last employer should be greater than 2 characters',
      'maxlength': 'Last employer should be not greater than 100 characters'
    },
    'LastDesignation': {
      'required': 'Last Designation is required.',
      'minlength': 'Last Designation should be greater than 2 characters',
      'maxlength': 'Last Designation should be not greater than 50 characters'
    },
    'NoticePeriod': {
      'required': 'Notice Period is required.',
      'minlength': 'Notice Period should be greater than 2 characters',
      'maxlength': 'Notice Period should be not greater than 25 characters'
    },
    'Experience': {
      'required': 'Experience is required.',
      'maxlength': 'Experience should be less than 25 year'
    },
    'SourceId': {
      'required': 'Source is required.'
    },
    'MedicalStatus': {
      'required': 'Medical status is required.',
      'minlength': 'Medical status should be greater than 2 characters',
      'maxlength': 'Medical status should be not greater than 100 characters'
    },
    'RoundId': {
      'required': 'Round name is required.',

    },
    'InterviewDate': {
      'required': 'Interview date is required.',

    },
    'InterviewerId': {
      'required': 'Interviewer name is required.',

    },
    'CandidateStatusId': {
      'required': 'status is required.',

    }
  };


  constructor(private _humanResourceService: HumanResourceService,
    private _formBuilder: FormBuilder,
    private _router: Router) { }

  ngOnInit(): void {
    this.createCandidateForm = this._formBuilder.group({
      ReferredBy: ['', [Validators.required, Validators.minLength(2), Validators.maxLength(20)]],
      Name: ['', [Validators.required, Validators.minLength(2), Validators.maxLength(250)]],
      LastEmployer: ['', [Validators.required, Validators.minLength(2), Validators.maxLength(100)]],
      LastDesignation: ['', [Validators.required, Validators.minLength(2)]],
      NoticePeriod: ['', [Validators.required, Validators.minLength(2), Validators.maxLength(25)]],
      Experience: ['', [Validators.required, Validators.maxLength(2)]],
      SourceId: ['', [Validators.required]],
      MedicalStatus: ['', [Validators.required, Validators.minLength(2), Validators.maxLength(100)]],
      RoundId: ['', [Validators.required]],
      InterviewDate: ['', [Validators.required]],
      InterviewerId: ['', [Validators.required]],
      CandidateStatusId: ['', [Validators.required]]
    });

    this._humanResourceService.GetSource().
      subscribe(
        data => this.source = data
      );
      console.log(this.source)

    this._humanResourceService.GetRound().subscribe(
      data => this.round = data
    );
    console.log(this.round)

    this._humanResourceService.GetCandidateStatus().subscribe(
      data => this.status = data
    );
    console.log(this.status)

    this._humanResourceService.GetInterviewer().subscribe(
      data => this.interviewer = data
    );

    console.log(this.interviewer);


    this.createCandidateForm.valueChanges.subscribe((data) => {
      this.logValidationErrors(this.createCandidateForm);
    });

    this._humanResourceService.GetCandidateById(this._humanResourceService.id).subscribe(
      (data) => {
        this.candidateInfoById = data;
        console.log(this.candidateInfoById);
        this.createCandidateForm.setValue({
          ReferredBy: this.candidateInfoById.referredBy,
          Name: this.candidateInfoById.candidateName,
          LastEmployer: this.candidateInfoById.lastEmployer,
          LastDesignation: this.candidateInfoById.lastDesignation,
          NoticePeriod: this.candidateInfoById.noticePeriod,
          Experience: this.candidateInfoById.experience,
          SourceId: this.candidateInfoById.sourceId,
          MedicalStatus: this.candidateInfoById.medicalStatus,
          RoundId: this.candidateInfoById.roundInformationId,
          InterviewDate: this.candidateInfoById.interviewDate,
          InterviewerId: this.candidateInfoById.interviewerId,
          CandidateStatusId: this.candidateInfoById.candidateStatusId
        });
      }
    );
  }

  logValidationErrors(group: FormGroup = this.createCandidateForm): void {
    // Object.keys(group.controls).forEach((key: string) => {
    //   const abstractControl = group.get(key);
    //   if (abstractControl instanceof FormGroup) {
    //     this.logValidationErrors(abstractControl);
    //   } else {
    //     this.formErrors[key] = '';
    //     if (abstractControl && !abstractControl.valid
    //       && (abstractControl.touched || abstractControl.dirty)) {
    //       const messages = this.validationMessages[key];
    //       for (const errorKey in abstractControl.errors) {
    //         if (errorKey) {
    //           this.formErrors[key] += messages[errorKey] + ' ';
    //         }
    //       }
    //     }
    //   }
    // });
  }

  UpdateCandidate() {
    this.updateCandidateRoundInformation = this.createCandidateForm.value;
    this._humanResourceService.UpdateCandidateRoundInformation(this.updateCandidateRoundInformation).subscribe();
  }

  goToPage(link: string) {
    this._router.navigateByUrl(`/${link}`);
  }
}
