import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { GetCandidateRound } from '../CustomModel/get-candidate-round';

@Injectable({
  providedIn: 'root'
})
export class InterviewerService {

  url = 'https://localhost:44373/api/InterviewManagement';

  constructor(private _http : HttpClient) { }

  GetAllCandidate() : Observable<GetCandidateRound[]>{
    return this._http.get<GetCandidateRound[]>(this.url + '/Get');
  }
}
