import { UserProfile } from './../Model/UserProfileModel';
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
  GetProfile(userid: Number) {
    let url = "https://localhost:50433/user/profile";
    return this.http.get<BResultModel<UserProfile>>(url);
}
    PostSignIn(request: SignInModel) {
        let url = "https://localhost:50433/user/sign-in";
        return this.http.post<BResultModel<Number>>(url, request);
    }
} 