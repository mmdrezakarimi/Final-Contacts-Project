import { SignUpModel } from './../Model/SingUpModel';
import { BResultModel } from './../Model/BResultModel';
import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from 'rxjs';
@Injectable ({providedIn: 'root'})
export class SignUpService
{
  constructor(private http: HttpClient)
  {}
    getSignUp(request: SignUpModel) {
        let url = "http://localhost:50433/user/SignUp";
        return this.http.post<BResultModel<Number>>(url, request);
    }
} 