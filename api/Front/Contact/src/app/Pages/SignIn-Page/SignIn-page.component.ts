import { UserService } from '../../Service/User-service';
import { SignInModel } from '../../Model/SignInModel';
import { Component } from "@angular/core";
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from "@angular/forms";
import { Router } from '@angular/router';

@Component({
    imports: [ReactiveFormsModule],
    selector: 'SignIn-page',
    templateUrl: './SignIn-page.component.html',
    styleUrl: './SignIn-page.component.css'
})
export class SignInPageComponent{
  constructor (private UserService: UserService, private router:Router){}

   signInform = new FormGroup({
    username: new FormControl(''),
    password: new FormControl('')
  });
  SignIn(){
      console.log(this.signInform.valid);

      let request: SignInModel = {
        username: this.signInform.value.username as string,
        password: this.signInform.value.password as string
      }
   this.UserService.PostSignIn(request).subscribe((response) => {
     if(response.success){
        sessionStorage.setItem('userid', response.data.toString())
        this.router.navigate(['profile']);
      }else{
       alert(response.errorMessage)
     }
    });
  }
}