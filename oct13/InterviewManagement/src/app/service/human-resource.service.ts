import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CreateCandidate } from '../CustomModel/create-candidate';
import { GetCandidateRound } from '../CustomModel/get-candidate-round';
import { GetCandidateStatus } from '../CustomModel/get-candidate-status';
import { GetRating } from '../CustomModel/get-rating';
import { GetSource } from '../CustomModel/get-source';


const url = 'https://localhost:44373/api/InterviewManagement';

@Injectable({
  providedIn: 'root'
})

export class HumanResourceService {


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
}
