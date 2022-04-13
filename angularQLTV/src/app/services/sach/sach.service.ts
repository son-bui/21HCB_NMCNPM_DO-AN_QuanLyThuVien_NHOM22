import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { RequestParameters } from 'src/app/models/request-parameter.model';

export class SachRequest extends RequestParameters {

}


@Injectable({
  providedIn: 'root'
})
export class SachService {

  constructor(private http: HttpClient) { }

  GetAllSach(val: any) {

  }
}
