import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CreateCandidate } from '../CustomModel/create-candidate';
import { GetCandidateRound } from '../CustomModel/get-candidate-round';


const url = 'https://localhost:44373/api/InterviewManagement';

@Injectable({
  providedIn: 'root'
})

export class HumanResourceService {


  constructor(private _http: HttpClient) { }

  Create(candidateInfo : any) {
    console.log('hi');
    console.log(candidateInfo);
    return this._http.post(url + '/Create', candidateInfo);
  }

  GetAllCandidate() : Observable<GetCandidateRound[]>{
    return this._http.get<GetCandidateRound[]>(url + '/Get');
  }

  GetCandidateById(id: any): Observable<GetCandidateRound>{
    return this._http.get<GetCandidateRound>(`${url}`+ '/GetById'+`?id=${id}`);
  }
}
