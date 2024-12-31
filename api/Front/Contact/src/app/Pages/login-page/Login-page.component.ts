import { Component } from "@angular/core";
import { FormControl, FormGroup, ReactiveFormsModule } from "@angular/forms";

@Component({
    imports: [ReactiveFormsModule],
    selector: 'login-page',
    templateUrl: './Login-page.component.html',
    styleUrl: './Login-page.component.css'
})
export class loginPageComponent{
  loginform = new FormGroup({
    username: new FormControl(''),
    password: new FormControl('')
  });
  login(){

  };
}