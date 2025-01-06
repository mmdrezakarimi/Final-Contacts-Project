import { UserProfile } from '../Model/UserProfileModel';
import { SignInModel } from '../Model/SignInModel';
import { BResultModel } from '../Model/BResultModel';
import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { SignUpModel } from '../Model/SignUpModel';

@Injectable ({providedIn: 'root'})
export class UserService
{
  constructor(private http: HttpClient)
  {}
    GetProfile(userId: any)
    {
     let url = "https://localhost:50433/user/profile";
     return this.http.get<BResultModel<UserProfile>>(url);
    }
    PostSignIn(request: SignInModel)
    {
        let url = "https://localhost:50433/user/sign-in";
        return this.http.post<BResultModel<Number>>(url, request);
    }
    
    PostSignUp(request: SignUpModel)
    {
        let url = "https://localhost:50433/user/sign-up";
        return this.http.post<BResultModel<Number>>(url, request);
    }
} 