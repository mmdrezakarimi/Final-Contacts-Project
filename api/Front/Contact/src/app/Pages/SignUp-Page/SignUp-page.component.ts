import { UserService } from './../../Service/User-service';
import { Component } from "@angular/core";
import { FormControl, FormGroup, ReactiveFormsModule } from "@angular/forms";
import { Router } from '@angular/router';
import { SignUpModel } from '../../Model/SignUpModel';

@Component({
    imports: [ReactiveFormsModule],
    selector: 'SignUp-Page',
    templateUrl: './SignUp-page.component.html',
    styleUrl: './SignUp-page.component.css'
})
export class signUpPageComponent {
    constructor(private UserService:UserService, private router:Router){}
    url="";
    signupForm = new FormGroup({
      username: new FormControl(''),
      fullname: new FormControl(''),  
      password: new FormControl(''),  
      imgdata: new FormControl(''),  
    })
    show(event: any){
        let file = event.target.files[0];
        let reader = new FileReader();
        reader.readAsDataURL(file);
        reader.onload = (e) => {
            if (e.target)
                {
                    this.url = e.target.result as string;
                }
            
        }
    }
    sigUp(){
     let request : SignUpModel = {
        UserName: this.signupForm.value.username as string,
        FullName: this.signupForm.value.fullname as string,
        Password: this.signupForm.value.password as string,
        PasswordConfirm: this.signupForm.value.password as string,
        ImgData: this.url
     }
     this.UserService.PostSignUp(request).subscribe((response) => {
        if(response.success){
            this.router.navigate(['signUp']);
        }else{
            alert(response.errorMessage);
        }
     } )
    }
    
}