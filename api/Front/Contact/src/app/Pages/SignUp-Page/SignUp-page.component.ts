import { SignUpService } from './../../Service/SignUp-service';
import { SignUpModel } from './../../Model/SingUpModel';
import { Component } from "@angular/core";
import { FormControl, FormGroup, ReactiveFormsModule } from "@angular/forms";

@Component({
    imports: [ReactiveFormsModule],
    selector: 'SignUp-page',
    templateUrl: './SignUp-page.component.html',
    styleUrl: './SignUp-page.component.css'
})
export class SignUpPageComponent{
  constructor (private SignUpService: SignUpService){}

  signUpform = new FormGroup({
    username: new FormControl(''),
    password: new FormControl('')
  });
  SignUp(){
      let request: SignUpModel = {
        username: this.signUpform.value.username as string,
        password: this.signUpform.value.password as string
      }
    this.SignUpService.getSignUp(request).subscribe((data) => console.log(data));
  };
}