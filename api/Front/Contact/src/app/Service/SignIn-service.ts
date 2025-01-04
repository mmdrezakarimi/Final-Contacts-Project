import { SignInModel } from '../Model/SignInModel';
import { BResultModel } from '../Model/BResultModel';
import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from 'rxjs';
@Injectable ({providedIn: 'root'})
export class SignInService
{
  constructor(private http: HttpClient)
  {}
    getSignIn(request: SignInModel) {
        let url = "https://localhost:50433/user/sign-In";
        return this.http.post<BResultModel<Number>>(url, request);
    }
} 