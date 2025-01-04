import { Routes } from '@angular/router';
import { ProfilePageComponent } from './Pages/Profile-page/Profile-page.component';
import { signInPageComponent } from './Pages/SignUp-Page/SignUp-page.component';
import { SignUpPageComponent } from './Pages/IN-Page/SignIn-page.component';

export const routes: Routes = [
    {path:'signUp', component:SignUpPageComponent},
    {path:'signIn', component:signInPageComponent},
    {path:'profile', component:ProfilePageComponent},
];
