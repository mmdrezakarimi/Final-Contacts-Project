import { SignInService } from './../../Service/SignIn-service';
import { SignInModel } from '../../Model/SignInModel';
import { Component } from "@angular/core";
import { FormControl, FormGroup, ReactiveFormsModule } from "@angular/forms";

@Component({
    imports: [ReactiveFormsModule],
    selector: 'SignIn-page',
    templateUrl: './SignIn-page.component.html',
    styleUrl: './SignIn-page.component.css'
})
export class SignInPageComponent{
  constructor (private SignInService: SignInService){}

  signInform = new FormGroup({
    username: new FormControl(''),
    password: new FormControl('')
  });
  SignIn(){
      this.signInform.valid

      let request: SignInModel = {
        username: this.signInform.value.username as string,
        password: this.signInform.value.password as string
      }
  this.SignInService.getSignIn(request).subscribe({
    next:(data) =>{ if(data.success){

    }else{
      alert(data.errorMessage)
    }},
    error: (error) => {

    }
    
  });
  };
}