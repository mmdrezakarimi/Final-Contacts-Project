import { SignInPageComponent } from './Pages/SignIn-Page/SignIn-page.component';
import { Routes } from '@angular/router';
import { ProfilePageComponent } from './Pages/Profile-page/Profile-page.component';
import { signUpPageComponent } from './Pages/SignUp-Page/SignUp-page.component';


export const routes: Routes = [
    {path:'signUp', component:signUpPageComponent},
    {path:'signIn', component:SignInPageComponent},
    {path:'profile', component:ProfilePageComponent},
];
