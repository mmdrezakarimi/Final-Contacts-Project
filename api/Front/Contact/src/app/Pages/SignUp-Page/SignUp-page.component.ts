import { Component } from "@angular/core";
import { FormControl, FormGroup, ReactiveFormsModule } from "@angular/forms";

@Component({
    imports: [ReactiveFormsModule],
    selector: 'SignUp-page',
    templateUrl: './SignUp-page.component.html',
    styleUrl: './SignUp-page.component.css'
})
export class SignUpPageComponent{
  signUpform = new FormGroup({
    username: new FormControl(''),
    password: new FormControl('')
  });
  SignUp(){

  };
}