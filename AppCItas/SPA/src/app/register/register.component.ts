import { Component, EventEmitter, Input, NgModule, OnInit, Output } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser'
import { AccountService } from '../_services/account.service';
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
 
export class RegisterComponent implements OnInit{
  //@Input() usersFromHomeComponent: any;
  @Output() cancelRegister = new EventEmitter();
  model: any = {};

  constructor(private accountServide: AccountService) { }

  ngOnInit(): void {
  }

  register(): void {
    this.accountServide.register(this.model).subscribe({
      next: () => {
        this.cancel();
      },
      error: error => console.log(error)
    });
  }

  cancel(): void {
    this.cancelRegister.emit(false);
  }
}
