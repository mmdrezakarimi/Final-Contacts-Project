import { Component, OnInit } from "@angular/core";
import { UserService } from '../../Service/User-service';

@Component({
    selector: 'Profile-Page',
    templateUrl: './Profile-page.component.html',
    styleUrl: './Profile-page.component.css'
})
export class ProfilePageComponent implements OnInit {
    constructor (private userService: UserService){ }
    username = "";
    fullname = "";
    avatar = "";


    ngOnInit()
    {
         let userId = sessionStorage.getItem('userid');

         this.userService.GetProfile(userId).subscribe((response) =>
        {
            this.username = response.data.Username;
            this.fullname = response.data.FullName;
            this.avatar = response.data.Username;
        });
    }
 }