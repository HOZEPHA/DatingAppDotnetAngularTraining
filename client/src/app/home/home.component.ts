import { Component, inject, OnInit } from '@angular/core';
import { RegisterComponent } from "../register/register.component";
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  imports: [RegisterComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent implements OnInit {

  http = inject(HttpClient);
  registerMode = false;
  Users: any;

  ngOnInit(): void {
    this.getUsers();
  }

  registerToggle() {
    this.registerMode = !this.registerMode;
  }

  cancelRegisterMode(event: boolean) {
    this.registerMode = event;
    }

  getUsers() {
    this.http.get('https://localhost:5001/api/users')
      .subscribe({
        next: response => this.Users = response,
        error: error => console.log(error),
        complete: () => console.log("the request has completed")
      });
  }
}
