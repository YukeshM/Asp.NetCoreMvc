import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { GetCandidateRound } from '../CustomModel/get-candidate-round';
import { GetCandidateStatus } from '../CustomModel/get-candidate-status';
import { GetRating } from '../CustomModel/get-rating';
import { GetSource } from '../CustomModel/get-source';

@Injectable({
  providedIn: 'root'
})
export class ReusableService {

  url = "https://localhost:44373/api/InterviewManagement";

  constructor(private _http: HttpClient) { }
  
  GetAllCandidate() : Observable<GetCandidateRound[]>{
    return this._http.get<GetCandidateRound[]>(this.url + '/Get');
  }

  GetCandidateStatus() : Observable<GetCandidateStatus[]>{
    return this._http.get<GetCandidateStatus[]>(this.url + '/GetCandidateStatus');
  }

  GetSource() : Observable<GetSource[]>{
    return this._http.get<GetSource[]>(this.url + '/GetSource');
  }

  GetRating() : Observable<GetRating[]>{
    return this._http.get<GetRating[]>(this.url + '/GetRating');
  }

}
