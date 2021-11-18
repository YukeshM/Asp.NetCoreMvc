import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CreateCandidate } from '../CustomModel/create-candidate';
import { GetCandidateRound } from '../CustomModel/get-candidate-round';
import { GetCandidateStatus } from '../CustomModel/get-candidate-status';
import { GetInterviewer } from '../CustomModel/get-interviewer';
import { GetRating } from '../CustomModel/get-rating';
import { GetRound } from '../CustomModel/get-round';
import { GetSkill } from '../CustomModel/get-skill';
import { GetSource } from '../CustomModel/get-source';
import { UpdateCandidateRoundInformation } from '../CustomModel/update-candidate-round-information';


const url = 'https://localhost:44373/api/InterviewManagement';

@Injectable({
  providedIn: 'root'
})

export class HumanResourceService {

  id = 0;

  constructor(private _http: HttpClient) { }

  Create(candidateInfo : any) {
    return this._http.post<CreateCandidate>(url + '/Create', candidateInfo);
  }

  GetAllCandidate() : Observable<GetCandidateRound[]>{
    return this._http.get<GetCandidateRound[]>(url + '/Get');
  }

  GetCandidateById(id: any): Observable<GetCandidateRound>{
    return this._http.get<GetCandidateRound>(`${url}`+ '/GetById'+`?id=${id}`);
  }

  GetCandidateStatus() : Observable<GetCandidateStatus[]>{
    return this._http.get<GetCandidateStatus[]>(url + '/GetCandidateStatus');
  }

  GetSource() : Observable<GetSource[]>{
    return this._http.get<GetSource[]>(url + '/GetSource');
  }

  GetRating() : Observable<GetRating[]>{
    return this._http.get<GetRating[]>(url + '/GetRating');
  }

  GetSkill() : Observable<GetSkill[]>{
    return this._http.get<GetSkill[]>(url + '/GetSkill');
  }

  GetRound() : Observable<GetRound[]>{
    return this._http.get<GetRound[]>(url + '/GetRound');
  }

  GetInterviewer() : Observable<GetInterviewer[]>{
    return this._http.get<GetInterviewer[]>(url + '/GetInterviewer');
  }
  
  UpdateCandidateRoundInformation(candidateRoundInformation : any)  {
    console.log(candidateRoundInformation);
    return this._http.put<UpdateCandidateRoundInformation>(url, '/UpdateCandidateRoundInformation',candidateRoundInformation);
  }
//set id for getting candidate details
  SetId(id : number){
    this.id = id;
  }

}
