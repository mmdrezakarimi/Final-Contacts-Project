import { ProfilePageComponent } from './Pages/Profile-page/Profile-page.component';
import { signInPageComponent } from './Pages/SignIn-Page/SignIn-page.component';
import { Routes } from '@angular/router';
import { SignUpPageComponent } from './Pages/SignUp-Page/SignUp-page.component';

export const routes: Routes = [
    {path:'signup', component:SignUpPageComponent},
    {path:'signIn', component:signInPageComponent},
    {path:'profile', component:ProfilePageComponent},
];
