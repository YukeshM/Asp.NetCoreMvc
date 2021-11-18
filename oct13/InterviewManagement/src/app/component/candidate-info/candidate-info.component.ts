import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CreateCandidate } from 'src/app/CustomModel/create-candidate';
import { GetSource } from 'src/app/CustomModel/get-source';
import { HumanResourceService } from 'src/app/service/human-resource.service';


@Component({
  selector: 'app-candidate-info',
  templateUrl: './candidate-info.component.html',
  styleUrls: ['./candidate-info.component.css']
})
export class CandidateInfoComponent implements OnInit {

  public source: GetSource[] = [];

  createCandidate: CreateCandidate = new CreateCandidate();

  createCandidateForm: FormGroup = this._formBuilder.group({
  });

  formErrors :any = {
    'ReferredBy': '',
    'Name': '',
    'LastEmployer': '',
    'LastDesignation': '',
    'NoticePeriod': '',
    'Experience': '',
    'SourceId': '',
    'MedicalStatus': ''
  };

  validationMessages :any = {
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
    }
  };


  constructor(private _humanResourceService: HumanResourceService,
    private _formBuilder: FormBuilder) { }


  ngOnInit(): void {
    this.createCandidateForm = this._formBuilder.group({
      ReferredBy: ['', [Validators.required, Validators.minLength(2), Validators.maxLength(20)]],
      Name: ['', [Validators.required, Validators.minLength(2), Validators.maxLength(250)]],
      LastEmployer: ['', [Validators.required, Validators.minLength(2), Validators.maxLength(100)]],
      LastDesignation: ['', [Validators.required, Validators.minLength(2)]],
      NoticePeriod: ['', [Validators.required, Validators.minLength(2), Validators.maxLength(25)]],
      Experience: ['',[Validators.required, Validators.maxLength(2)]],
      SourceId: ['',[Validators.required]],
      MedicalStatus: ['',[Validators.required, Validators.minLength(2), Validators.maxLength(100)]]
    });

    this._humanResourceService.GetSource().
      subscribe(
        data => this.source = data
      );

    this.createCandidateForm.valueChanges.subscribe((data) => {
      this.logValidationErrors(this.createCandidateForm);
    });
  }

  CreateCandidate(): void {
    //this.createCandidate = this.createCandidateForm.value
    this.createCandidate.ReferredBy = this.createCandidateForm.value.ReferredBy,
      this.createCandidate.Name = this.createCandidateForm.value.Name,
      this.createCandidate.LastEmployer = this.createCandidateForm.value.LastEmployer,
      this.createCandidate.LastDesignation = this.createCandidateForm.value.LastDesignation,
      this.createCandidate.Experience = this.createCandidateForm.value.Experience,
      this.createCandidate.NoticePeriod = this.createCandidateForm.value.NoticePeriod,
      this.createCandidate.SourceId = this.createCandidateForm.value.SourceId,
      this.createCandidate.MedicalStatus = this.createCandidateForm.value.MedicalStatus
    console.warn(this.createCandidate);
    this._humanResourceService.Create(this.createCandidate).subscribe();
  }

  logValidationErrors(group: FormGroup = this.createCandidateForm): void {
    Object.keys(group.controls).forEach((key: string) => {
      const abstractControl = group.get(key);
      if (abstractControl instanceof FormGroup) {
        this.logValidationErrors(abstractControl);
      } else {
        this.formErrors[key] = '';
        if (abstractControl && !abstractControl.valid
            && (abstractControl.touched || abstractControl.dirty)) {
          const messages = this.validationMessages[key];
          for (const errorKey in abstractControl.errors) {
            if (errorKey) {
              this.formErrors[key] += messages[errorKey] + ' ';
            }
          }
        }
      }
    });
}

}
