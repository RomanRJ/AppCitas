import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { IUser } from '../_models/iuser';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {}
  loggedIn = false;
  users: any;

  constructor(private http:HttpClient, private accountService: AccountService) { }


  ngOnInit(): void {
    this.getCurrentUser();
  }
  

  getCurrentUser() {
    this.accountService.currentUser$.subscribe({
      next: user => this.loggedIn = !!user,
      error: error => console.log(error)
    });
  }

  

  login(): void {
    this.accountService.login(this.model).subscribe({
      next: response => {
        console.log(response);
        this.loggedIn = true;
      },
      error: error => console.log(error)
     })

  }
  logout(): void {
    this.accountService.logout();
    this.loggedIn = false;
  }
}
